namespace project_gui.DataModels
{
	public class Addresses
	{
		public int Id { get; set; }
		public string? Address { get; set; }
		public virtual Cities? City { get; set; }
	}
}
