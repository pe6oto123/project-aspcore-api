namespace project_gui.DataModels
{
	public class Universities
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public virtual Addresses? Address { get; set; }
	}
}
