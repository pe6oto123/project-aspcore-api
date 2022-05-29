namespace project_gui.DataModels
{
	public class Teachers
	{
		public int Id { get; set; }
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public string? Position { get; set; }
		public virtual Addresses? Address { get; set; }
		public virtual ICollection<Departments>? Departments { get; set; }
	}
}
