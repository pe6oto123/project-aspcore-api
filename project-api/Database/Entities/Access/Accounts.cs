using System.ComponentModel.DataAnnotations;

namespace project_api.Entities
{
	public class Accounts
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(50)]
		public string? UserName { get; set; }

		[Required]
		public string? Password { get; set; }

		[Required]
		public bool IsAdmin { get; set; }
	}
}
