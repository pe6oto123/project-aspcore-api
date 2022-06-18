using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project_api.Entities
{
	public class Students
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(50)]
		public string? FirstName { get; set; }

		[Required]
		[StringLength(50)]
		public string? LastName { get; set; }

		[Required]
		public DateTime EnrolmentDate { get; set; }

		[StringLength(12)]
		public string? FacultyNumber { get; set; }

		[Required]
		public virtual Addresses? Address { get; set; }

		[Required]
		public virtual Universities? Universities { get; set; }

		[Required]
		public virtual Departments? Department { get; set; }

		public virtual ICollection<StudentsSubjects>? StudentsSubjects { get; set; }
	}

	public class StudentsSubjects
	{
		[Key, Column(Order = 0)]
		public int StudentsId { get; set; }

		[Key, Column(Order = 1)]
		public int SubjectsId { get; set; }

		public virtual Students? Student { get; set; }

		public virtual Subjects? Subject { get; set; }

		[MaxLength(20)]
		public string? Grade { get; set; }
	}
}
