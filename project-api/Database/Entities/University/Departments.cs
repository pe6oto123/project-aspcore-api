using System.ComponentModel.DataAnnotations;

namespace project_api.Entities
{
	public class Departments
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(50)]
		public string? Name { get; set; }

		public virtual Universities? University { get; set; }

		public virtual ICollection<Teachers>? Teachers { get; set; }
	}
}
