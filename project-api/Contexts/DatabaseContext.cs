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

		DbSet<Accounts> Accounts { get; set; }
		DbSet<Universities> Universities { get; set; }
		DbSet<Departments> Departments { get; set; }
		DbSet<Subjects> Subjects { get; set; }
		DbSet<Students> Students { get; set; }
		DbSet<Teachers> Teachers { get; set; }
		DbSet<Addresses> Addresss { get; set; }
		DbSet<Cities> Cities { get; set; }
		DbSet<Countries> Countries { get; set; }
	}
}
