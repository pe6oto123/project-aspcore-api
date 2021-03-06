using System.ComponentModel.DataAnnotations;

namespace project_api.Entities
{
	public class Countries
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(50)]
		public string? Name { get; set; }

		[StringLength(50)]
		public string? Continent { get; set; }
	}
}
