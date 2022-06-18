using Newtonsoft.Json.Linq;
using project_gui.Api;
using project_gui.DataModels._uitl;
using System.Net.Http.Json;

namespace project_gui.DataModels
{
	public class Subjects
	{
		public int? Id { get; set; }
		public string? Name { get; set; }
		public virtual Departments? Department { get; set; }
		public virtual ICollection<StudentsSubjects>? StudentsSubjects { get; set; }
	}

	internal class SubjectsController
	{
		private static HttpResponseMessage? response;
		internal static async Task<List<dynamic>?> GetSubjects()
		{
			response = await Client.GetClient().GetAsync($"api/Subjects");

			if (response.IsSuccessStatusCode)
			{
				var subjects = await response.Content.ReadFromJsonAsync<IEnumerable<Subjects>>();
				var query = from subject in subjects
							select new
							{
								subject.Id,
								subject.Name,
								Department = subject.Department?.Name
							};
				return query.ToList<dynamic>();
			}
			return null;
		}

		internal static async Task<List<dynamic>?> GetSubjectsInDepartment(int? id)
		{
			response = await Client.GetClient().GetAsync($"api/Subjects/Department/{id}");
			if (response.IsSuccessStatusCode)
			{
				var subjects = await response.Content.ReadFromJsonAsync<IEnumerable<Subjects>>();
				var query = from subject in subjects
							select new
							{
								subject.Id,
								subject.Name,
								Department = subject.Department?.Name
							};
				return query.ToList<dynamic>();
			}
			return null;
		}

		internal static async Task<IEnumerable<Subjects>?> GetSubjectsInDepartmentFull(int? id)
		{
			if (id == null)
				return null;

			response = await Client.GetClient().GetAsync($"api/Subjects/Department/{id}?isAlsoFree=true");
			if (response.IsSuccessStatusCode)
			{
				return await response.Content.ReadFromJsonAsync<IEnumerable<Subjects>>();
			}
			return null;
		}

		internal static async Task<Subjects?> GetSubjectById(int? id)
		{
			response = await Client.GetClient().GetAsync($"api/Subjects/{id}");
			if (response.IsSuccessStatusCode)
			{
				return await response.Content.ReadFromJsonAsync<Subjects>();
			}
			return null;
		}

		internal static async Task<bool> CreateSubject(Subjects? subject)
		{
			response = await Client.GetClient().PostAsJsonAsync($"api/Subjects/", subject);

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

		internal static async Task<bool> UpdateSubjects(Subjects? subject)
		{
			response = await Client.GetClient().PutAsJsonAsync($"api/Subjects/{ subject.Id}", subject);

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

		public static async Task<bool> DeleteSubject(int? id)
		{
			if (MessageBox.Show($"Are you sure you want to delete the subject with id: {id}", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				response = await Client.GetClient().DeleteAsync($"api/Subjects/{id}");
				if (response.IsSuccessStatusCode)
					return true;

				MessageBox.Show("There was a problem while deleting the entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return false;
		}
	}
}
