using Newtonsoft.Json.Linq;
using project_gui.Api;
using project_gui.DataModels._uitl;
using System.Net.Http.Json;

namespace project_gui.DataModels
{
	public class Universities
	{
		public int? Id { get; set; }
		public string? Name { get; set; }
		public virtual Addresses? Address { get; set; }
	}

	internal class UniversitiesController
	{
		private static HttpResponseMessage? response;

		internal static async Task<List<dynamic>?> GetUniversities()
		{
			response = await Client.GetClient().GetAsync($"api/Universities");

			if (response.IsSuccessStatusCode)
			{
				var universities = await response.Content.ReadFromJsonAsync<IEnumerable<Universities>>();
				var query = from university in universities
							select new
							{
								university.Id,
								university.Name,
								university.Address.MainAddress,
								CityName = university.Address.City?.Name
							};
				return query.ToList<dynamic>();
			}
			return null;
		}

		internal static async Task<Universities?> GetUniversityById(int? id)
		{
			if (id == null)
				return null;

			response = await Client.GetClient().GetAsync($"api/Universities/{id}");
			if (response.IsSuccessStatusCode)
			{
				return await response.Content.ReadFromJsonAsync<Universities>();
			}
			return null;
		}

		internal static async Task<bool> CreateUniversity(Universities? university)
		{
			response = await Client.GetClient().PostAsJsonAsync($"api/Universities", university);

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

		internal static async Task<bool> UpdateUniversity(Universities? university)
		{
			response = await Client.GetClient().PutAsJsonAsync($"api/Universities/{university.Id}", university);

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

		internal static async Task<bool> DeleteUniversity(int? id)
		{
			if (MessageBox.Show($"Are you sure you want to delete the university with id: {id}", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				response = await Client.GetClient().DeleteAsync($"api/Universities/{id}");
				if (response.IsSuccessStatusCode)
					return true;
			}

			MessageBox.Show("There was a problem while deleting the entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return false;
		}
	}
}
