using System.ComponentModel.DataAnnotations;

namespace project_api.Entities
{
	public class Addresses
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(50)]
		public string? Address { get; set; }

		public virtual Cities? City { get; set; }
	}
}
