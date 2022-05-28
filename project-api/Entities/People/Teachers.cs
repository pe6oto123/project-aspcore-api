using System.ComponentModel.DataAnnotations;

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

		public virtual Addresses? Address { get; set; }

		public virtual ICollection<Departments>? Departments { get; set; }
	}
}
