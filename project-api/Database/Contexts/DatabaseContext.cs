using Microsoft.EntityFrameworkCore;
using project_api.Entities;

namespace project_api.Contexts
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
		{
			// Default constructor
		}

		public DbSet<Accounts> Accounts => Set<Accounts>();
		public DbSet<Universities> Universities => Set<Universities>();
		public DbSet<Departments> Departments => Set<Departments>();
		public DbSet<Subjects> Subjects => Set<Subjects>();
		public DbSet<Students> Students => Set<Students>();
		public DbSet<StudentsSubjects> StudentsSubjects => Set<StudentsSubjects>();
		public DbSet<Enrolment> Enrolments => Set<Enrolment>();
		public DbSet<Teachers> Teachers => Set<Teachers>();
		public DbSet<Addresses> Address => Set<Addresses>();
		public DbSet<Cities> Cities => Set<Cities>();
		public DbSet<Countries> Countries => Set<Countries>();

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder
				.Entity<Students>()
				.HasOne(s => s.Enrolment)
				.WithOne(s => s.Student)
				.HasForeignKey<Enrolment>(s => s.Id)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder
				.Entity<StudentsSubjects>()
				.HasKey(table => new
				{
					table.StudentsId,
					table.SubjectsId
				});

			modelBuilder
				.Entity<StudentsSubjects>()
				.HasOne(s => s.Student)
				.WithMany(s => s.StudentsSubjects)
				.HasForeignKey(s => s.StudentsId)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder
				.Entity<StudentsSubjects>()
				.HasOne(s => s.Subject)
				.WithMany(s => s.StudentsSubjects)
				.HasForeignKey(s => s.SubjectsId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
