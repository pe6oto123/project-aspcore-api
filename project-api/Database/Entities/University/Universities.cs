using System.ComponentModel.DataAnnotations;

namespace project_api.Entities
{
	public class Universities
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(50)]
		public string? Name { get; set; }

		[Required]
		public virtual Addresses? Address { get; set; }
	}
}
