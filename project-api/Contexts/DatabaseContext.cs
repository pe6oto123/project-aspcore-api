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
		public DbSet<Teachers> Teachers => Set<Teachers>();
		public DbSet<Addresses> Address => Set<Addresses>();
		public DbSet<Cities> Cities => Set<Cities>();
		public DbSet<Countries> Countries => Set<Countries>();
	}
}
