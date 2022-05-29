namespace project_gui.DataModels
{
	public class Departments
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public virtual Universities? University { get; set; }
		public virtual ICollection<Teachers>? Teachers { get; set; }
	}
}
