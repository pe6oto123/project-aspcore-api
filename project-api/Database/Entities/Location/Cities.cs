using System.ComponentModel.DataAnnotations;

namespace project_api.Entities
{
	public class Cities
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(50)]
		public string? Name { get; set; }

		[StringLength(50)]
		public string? Region { get; set; }

		public int? Population { get; set; }

		public virtual Countries? Country { get; set; }
	}
}
