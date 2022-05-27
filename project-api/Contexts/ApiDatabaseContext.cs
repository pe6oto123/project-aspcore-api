using Microsoft.EntityFrameworkCore;

namespace project_api.Contexts
{
	public class ApiDatabaseContext : DbContext
	{
		public ApiDatabaseContext(DbContextOptions<ApiDatabaseContext> options) : base(options)
		{
		}
	}
}
