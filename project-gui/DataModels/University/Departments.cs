using Newtonsoft.Json.Linq;
using project_gui.Api;
using project_gui.DataModels._uitl;
using System.Net.Http.Json;

namespace project_gui.DataModels
{
	public class Departments
	{
		public int? Id { get; set; }
		public string? Name { get; set; }
		public virtual Universities? University { get; set; }
		public virtual ICollection<Teachers>? Teachers { get; set; }
	}

	internal class DepartmentsController
	{
		private static HttpResponseMessage? response;

		internal static async Task<List<dynamic>?> GetDepartments()
		{
			response = await Client.GetClient().GetAsync($"api/Departments");

			if (response.IsSuccessStatusCode)
			{
				var departments = await response.Content.ReadFromJsonAsync<IEnumerable<Departments>>();
				var query = from department in departments
							select new
							{
								department.Id,
								department.Name,
								University = department.University?.Name
							};
				return query.ToList<dynamic>();
			}
			return null;
		}

		internal static async Task<List<dynamic>?> GetDepatmentsInUniversity(int? universityId)
		{
			response = await Client.GetClient().GetAsync($"api/Departments/University/{universityId}");

			if (response.IsSuccessStatusCode)
			{
				var departments = await response.Content.ReadFromJsonAsync<IEnumerable<Departments>>();
				var query = from department in departments
							select new
							{
								department.Id,
								department.Name,
								University = department.University?.Name
							};
				return query.ToList<dynamic>();
			}
			return null;
		}

		internal static async Task<IEnumerable<Departments>?> GetDepatmentsInUniversityFull(int? universityId)
		{
			response = await Client.GetClient().GetAsync($"api/Departments/University/{universityId}");

			if (response.IsSuccessStatusCode)
			{
				return await response.Content.ReadFromJsonAsync<IEnumerable<Departments>>();
			}
			return null;
		}

		internal static async Task<Departments?> GetDepartmentById(int? id)
		{
			if (id == null)
				return null;

			response = await Client.GetClient().GetAsync($"api/Departments/{id}");
			if (response.IsSuccessStatusCode)
			{
				return await response.Content.ReadFromJsonAsync<Departments>();
			}
			return null;
		}

		internal static async Task<bool> CreateDepartment(Departments? department)
		{
			response = await Client.GetClient().PostAsJsonAsync($"api/Departments", department);
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

		internal static async Task<bool> UpdateDepartment(Departments? department)
		{
			response = await Client.GetClient().PutAsJsonAsync($"api/Departments/{department.Id}", department);
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

		internal static async Task<bool> DeleteDepartment(int? id)
		{
			if (MessageBox.Show($"Are you sure you want to delete the department with id: {id}", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				response = await Client.GetClient().DeleteAsync($"api/Departments/{id}");
				if (response.IsSuccessStatusCode)
					return true;

				MessageBox.Show("There was a problem while deleting the entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return false;
		}
	}
}
