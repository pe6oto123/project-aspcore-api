using System.ComponentModel.DataAnnotations;

namespace project_api.Entities
{
	public class Students
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(50)]
		public string FirstName { get; set; }

		[Required]
		[StringLength(50)]
		public string LastName { get; set; }

		[Required]
		public string FacultyNum { get; set; }

		public virtual Departments Department { get; set; }

		public virtual ICollection<Subjects> Subjects { get; set; }
	}
}
