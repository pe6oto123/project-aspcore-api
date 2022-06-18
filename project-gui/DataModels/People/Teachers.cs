using Newtonsoft.Json.Linq;
using project_gui.Api;
using project_gui.DataModels._uitl;
using System.Net.Http.Json;

namespace project_gui.DataModels
{
	public class Teachers
	{
		public int? Id { get; set; }
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public string? Position { get; set; }
		public virtual Addresses? Address { get; set; }
		public virtual Universities? Universities { get; set; }
		public virtual ICollection<TeachersDepartments>? TeachersDepartments { get; set; }
	}

	public class TeachersDepartments
	{
		public int? DepartmentsId { get; set; }

		public int? TeachersId { get; set; }
	}

	public class TeachersController
	{
		private static HttpResponseMessage? response;

		internal static async Task<List<dynamic>?> GetTeachers()
		{
			response = await Client.GetClient().GetAsync($"api/Teachers");

			if (response.IsSuccessStatusCode)
			{
				var teachers = await response.Content.ReadFromJsonAsync<IEnumerable<Teachers>>();
				var query = from teacher in teachers
							select new
							{
								teacher.Id,
								teacher.FirstName,
								teacher.LastName,
								teacher.Position,
								University = teacher.Universities.Name
							};
				return query.ToList<dynamic>();
			}
			return null;
		}

		internal static async Task<Teachers?> GetTeacherById(int? id)
		{
			if (id == null)
				return null;

			response = await Client.GetClient().GetAsync($"api/Teachers/{id}");
			if (response.IsSuccessStatusCode)
			{
				return await response.Content.ReadFromJsonAsync<Teachers>();
			}
			return null;
		}

		internal static async Task<List<int?>?> GetDepartmentsIds(int? id)
		{
			if (id == null)
				return null;

			response = await Client.GetClient().GetAsync($"api/Teachers/DepartmentsIds/{id}");
			if (response.IsSuccessStatusCode)
			{
				return await response.Content.ReadFromJsonAsync<List<int?>>();
			}
			return null;
		}

		internal static async Task<bool> CreateTeacher(Teachers? teacher)
		{
			response = await Client.GetClient().PostAsJsonAsync($"api/Teachers/", teacher);

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

		internal static async Task<bool> UpdateTeacher(Teachers? teacher)
		{
			response = await Client.GetClient().PutAsJsonAsync($"api/Teachers/{teacher.Id}", teacher);

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

		public static async Task<bool> DeleteTeacher(int? id)
		{
			if (MessageBox.Show($"Are you sure you want to delete the teacher with id: {id}", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				response = await Client.GetClient().DeleteAsync($"api/Teachers/{id}");
				if (response.IsSuccessStatusCode)
					return true;

				MessageBox.Show("There was a problem while deleting the entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return false;
		}
	}
}
