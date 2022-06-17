using project_gui.Api;

namespace project_gui.DataModels
{
	public class Students
	{
		public int? Id { get; set; }
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public virtual Addresses? Address { get; set; }
		public virtual Universities? Universities { get; set; }
		public virtual Departments? Department { get; set; }
		public virtual ICollection<Subjects>? Subjects { get; set; }
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

			if (re)
		}
	}
}
