using Microsoft.EntityFrameworkCore;
using project_api.Entities;

namespace project_api.Contexts
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
		{
			// Default constructor
			//ChangeTracker.CascadeDeleteTiming = CascadeTiming.OnSaveChanges;
			//ChangeTracker.DeleteOrphansTiming = CascadeTiming.OnSaveChanges;
		}

		public DbSet<Accounts> Accounts => Set<Accounts>();
		public DbSet<Universities> Universities => Set<Universities>();
		public DbSet<Departments> Departments => Set<Departments>();
		public DbSet<Subjects> Subjects => Set<Subjects>();
		public DbSet<Students> Students => Set<Students>();
		public DbSet<StudentsSubjects> StudentsSubjects => Set<StudentsSubjects>();
		public DbSet<Teachers> Teachers => Set<Teachers>();
		public DbSet<TeachersDepartments> TeachersDepartments => Set<TeachersDepartments>();
		public DbSet<Addresses> Address => Set<Addresses>();
		public DbSet<Cities> Cities => Set<Cities>();
		public DbSet<Countries> Countries => Set<Countries>();

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder
				.Entity<StudentsSubjects>()
				.HasKey(table => new
				{
					table.StudentsId,
					table.SubjectsId
				});

			modelBuilder
				.Entity<TeachersDepartments>()
				.HasKey(table => new
				{
					table.DepartmentsId,
					table.TeachersId
				});

			modelBuilder
				.Entity<TeachersDepartments>()
				.HasOne(s => s.Teacher)
				.WithMany(s => s.TeachersDepartments)
				.HasForeignKey(s => s.TeachersId);
			//.OnDelete(DeleteBehavior.Cascade);

			modelBuilder
				.Entity<TeachersDepartments>()
				.HasOne(s => s.Department)
				.WithMany(s => s.TeachersDepartments)
				.HasForeignKey(s => s.DepartmentsId);
			//.OnDelete(DeleteBehavior.Cascade);

			modelBuilder
				.Entity<StudentsSubjects>()
				.HasOne(s => s.Student)
				.WithMany(s => s.StudentsSubjects)
				.HasForeignKey(s => s.StudentsId);
			//.OnDelete(DeleteBehavior.Cascade);

			modelBuilder
				.Entity<StudentsSubjects>()
				.HasOne(s => s.Subject)
				.WithMany(s => s.StudentsSubjects)
				.HasForeignKey(s => s.SubjectsId);
			//.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
