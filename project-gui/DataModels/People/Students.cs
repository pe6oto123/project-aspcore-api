namespace project_gui.DataModels
{
	public class Students
	{
		public int Id { get; set; }
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public virtual Addresses? Address { get; set; }
		public virtual Universities? Universities { get; set; }
		public virtual Departments? Department { get; set; }
		public virtual ICollection<Subjects>? Subjects { get; set; }
	}

	public class Enrolment
	{
		// Foreign key
		public virtual Students? Student { get; set; }
		public DateTime EnrolmentDate { get; set; }
		public string? FacultyNumber { get; set; }
	}
}
