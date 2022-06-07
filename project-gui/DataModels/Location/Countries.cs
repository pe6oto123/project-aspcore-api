using Newtonsoft.Json.Linq;
using project_gui.Api;
using project_gui.DataModels._uitl;
using System.Net.Http.Json;

namespace project_gui.DataModels
{
	public class Countries
	{
		public int? Id { get; set; }
		public string? Name { get; set; }
		public string? Continent { get; set; }
	}

	public static class CountriesController
	{
		private static HttpResponseMessage? response;

		internal static async Task<List<dynamic>?> GetCountries()
		{
			response = await Client.GetClient().GetAsync("api/Countries");

			if (response.IsSuccessStatusCode)
			{
				var countries = await response.Content.ReadFromJsonAsync<IEnumerable<Countries>>();
				var query = from country in countries
							select new
							{
								country.Id,
								country.Name,
								country.Continent,
							};
				return query.ToList<dynamic>();
			}

			return null;
		}

		internal static async Task<Countries?> GetCountryById(int? id)
		{
			response = await Client.GetClient().GetAsync($"api/Countries/{id}");
			if (response.IsSuccessStatusCode)
			{
				return await response.Content.ReadFromJsonAsync<Countries>();
			}
			return null;
		}

		internal static List<dynamic>? GetCountriesByAttribute(string attribute, string? searchParam, List<dynamic> dataSource)
		{
			var searchList = dataSource;

			return attribute switch
			{
				"Name" => searchList.Where(s => s.Name == searchParam).ToList(),
				"Continent" => searchList.Where(s => s.Continent == searchParam).ToList(),
				_ => null,
			};
		}

		internal static async Task CreateCountry(Countries? country)
		{
			response = await Client.GetClient().PostAsJsonAsync($"api/Countries/", new { name = country.Name, continent = country.Continent });

			if (response.IsSuccessStatusCode)
			{
				return;
			}
			else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
			{
				dynamic responseBody = JObject.Parse(await response.Content.ReadAsStringAsync());
				MessageBox.Show(HelperFuncs.RequiredFieldsError(responseBody), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			MessageBox.Show("There was a problem while creating the entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static async Task UpdateCountry(Countries? country)
		{
			response = await Client.GetClient().PutAsJsonAsync($"api/Countries/{country.Id}", country);

			if (response.IsSuccessStatusCode)
			{
				return;
			}
			else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
			{
				dynamic responseBody = JObject.Parse(await response.Content.ReadAsStringAsync());
				MessageBox.Show(HelperFuncs.RequiredFieldsError(responseBody), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			MessageBox.Show("There was a problem while updating the entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public static async Task DeleteCountry(int? id)
		{
			if (MessageBox.Show($"Are you sure you want to delete the country with id: {id}", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				response = await Client.GetClient().DeleteAsync($"api/Countries/{id}");
				if (response.IsSuccessStatusCode)
					return;

				MessageBox.Show("There was a problem while deleting the entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
