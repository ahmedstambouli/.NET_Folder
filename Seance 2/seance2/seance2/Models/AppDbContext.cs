using Microsoft.EntityFrameworkCore;

namespace seance2.Models
{
	public class AppDbContext:DbContext
	{
		public AppDbContext(DbContextOptions options):
						base(options)
		{

		}


		public DbSet<Movie> movies { get; set; }
		public DbSet<Customer> customers { get; set; }


	}
}
