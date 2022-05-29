namespace project_gui.DataModels
{
	public class Cities
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? Region { get; set; }
		public int? Population { get; set; }
		public virtual Countries? Country { get; set; }
	}
}
