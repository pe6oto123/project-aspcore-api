using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project_api.Entities
{
	public class Teachers
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
		[StringLength(50)]
		public string? Position { get; set; }

		[Required]
		public virtual Addresses? Address { get; set; }

		[Required]
		public virtual Universities? Universities { get; set; }

		public virtual ICollection<TeachersDepartments>? TeachersDepartments { get; set; }
	}

	public class TeachersDepartments
	{
		[Key, Column(Order = 0)]
		public int DepartmentsId { get; set; }

		[Key, Column(Order = 1)]
		public int TeachersId { get; set; }

		public virtual Departments? Department { get; set; }

		public virtual Teachers? Teacher { get; set; }
	}
}
