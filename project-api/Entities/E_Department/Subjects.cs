using System.ComponentModel.DataAnnotations;

namespace project_api.Entities
{
	public class Subjects
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(50)]
		public string Name { get; set; }

		public virtual Departments Department { get; set; }

		public virtual ICollection<Students> Students { get; set; }
	}
}
