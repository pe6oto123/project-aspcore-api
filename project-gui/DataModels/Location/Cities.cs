using Newtonsoft.Json.Linq;
using project_gui.Api;
using project_gui.DataModels._uitl;
using System.Net.Http.Json;

namespace project_gui.DataModels
{
	public class Cities
	{
		public int? Id { get; set; }
		public string? Name { get; set; }
		public string? Region { get; set; }
		public int? Population { get; set; }
		public virtual Countries? Country { get; set; }
	}

	internal static class CitiesController
	{
		private static HttpResponseMessage? response;

		internal static async Task<List<dynamic>?> GetCities(int? countryId)
		{
			response = await Client.GetClient().GetAsync($"api/Cities{(countryId != null ? $"?countryId={countryId}" : "")}");

			if (response.IsSuccessStatusCode)
			{
				var cities = await response.Content.ReadFromJsonAsync<IEnumerable<Cities>>();
				var query = from city in cities
							select new
							{
								city.Id,
								city.Name,
								city.Region,
								city.Population
							};
				return query.ToList<dynamic>();
			}

			return null;
		}

		internal static async Task<Cities?> GetCityById(int? id)
		{
			response = await Client.GetClient().GetAsync($"api/Cities/{id}");
			if (response.IsSuccessStatusCode)
			{
				return await response.Content.ReadFromJsonAsync<Cities>();
			}
			return null;
		}

		internal static async Task<bool> CreateCity(Cities? city)
		{
			response = await Client.GetClient().PostAsJsonAsync($"api/Cities/", city);

			if (response.IsSuccessStatusCode)
			{
				return true;
			}
			else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
			{
				dynamic responseBody = JObject.Parse(await response.Content.ReadAsStringAsync());
				MessageBox.Show(HelperFuncs.RequiredFieldsError(responseBody), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			MessageBox.Show("There was a problem while creating the entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return false;
		}

		internal static async Task<bool> UpdateCity(Cities? city)
		{
			response = await Client.GetClient().PutAsJsonAsync($"api/Cities/{city.Id}", city);

			if (response.IsSuccessStatusCode)
			{
				return true;
			}
			else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
			{
				dynamic responseBody = JObject.Parse(await response.Content.ReadAsStringAsync());
				MessageBox.Show(HelperFuncs.RequiredFieldsError(responseBody), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			MessageBox.Show("There was a problem while updating the entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return false;
		}

		public static async Task<bool> DeleteCity(int? id)
		{
			if (MessageBox.Show($"Are you sure you want to delete the city with id: {id}", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				response = await Client.GetClient().DeleteAsync($"api/Cities/{id}");
				if (response.IsSuccessStatusCode)
					return true;
			}
			MessageBox.Show("There was a problem while deleting the entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return false;
		}
	}
}
