namespace project_gui.DataModels
{
	public class Subjects
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public virtual Departments? Department { get; set; }
		public virtual ICollection<Students>? Students { get; set; }
	}
}
