using Newtonsoft.Json.Linq;
using project_gui.Api;
using project_gui.DataModels._uitl;
using System.Net.Http.Json;

namespace project_gui.DataModels
{
	public class Students
	{
		public int? Id { get; set; }
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public DateTime EnrolmentDate { get; set; }
		public string? FacultyNumber { get; set; }
		public virtual Addresses? Address { get; set; }
		public virtual Universities? Universities { get; set; }
		public virtual Departments? Department { get; set; }
		public virtual ICollection<StudentsSubjects>? StudentsSubjects { get; set; }
	}

	public class StudentsSubjects
	{
		public int? StudentsId { get; set; }

		public int? SubjectsId { get; set; }

		public string? Grade { get; set; }
	}

	public class StudentsController
	{
		private static HttpResponseMessage? response;

		internal static async Task<List<dynamic>?> GetStudents()
		{
			response = await Client.GetClient().GetAsync($"api/Students");

			if (response.IsSuccessStatusCode)
			{
				var students = await response.Content.ReadFromJsonAsync<IEnumerable<Students>>();
				var query = from student in students
							select new
							{
								student.Id,
								student.FirstName,
								student.LastName,
								student.FacultyNumber,
								Department = student.Department?.Name,
								University = student.Universities?.Name
							};
				return query.ToList<dynamic>();
			}
			return null;
		}

		internal static async Task<Students?> GetStudentById(int? id)
		{
			if (id == null)
				return null;

			response = await Client.GetClient().GetAsync($"api/Students/{id}");

			if (response.IsSuccessStatusCode)
			{
				return await response.Content.ReadFromJsonAsync<Students>();
			}
			return null;
		}

		internal static async Task<List<int?>?> GetSubjectsIds(int? id)
		{
			if (id == null)
				return null;

			response = await Client.GetClient().GetAsync($"api/Students/SubjectsIds/{id}");
			if (response.IsSuccessStatusCode)
			{
				return await response.Content.ReadFromJsonAsync<List<int?>>();
			}
			return null;
		}

		internal static async Task<bool> CreateStudent(Students? students)
		{
			response = await Client.GetClient().PostAsJsonAsync($"api/Students/", students);

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

		internal static async Task<bool> UpdateStudent(Students? student)
		{
			response = await Client.GetClient().PutAsJsonAsync($"api/Students/{student.Id}", student);

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

		internal static async Task<bool> DeleteStudent(int? id)
		{
			if (MessageBox.Show($"Are you sure you want to delete the student with id: {id}", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				response = await Client.GetClient().DeleteAsync($"api/Students/{id}");
				if (response.IsSuccessStatusCode)
					return true;

				MessageBox.Show("There was a problem while deleting the entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return false;
		}
	}
}
