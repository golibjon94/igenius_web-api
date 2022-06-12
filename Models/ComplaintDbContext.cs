using Microsoft.EntityFrameworkCore;

namespace ComplaintsApi.Models
{
	public class ComplaintDbContext : DbContext
	{
		public ComplaintDbContext(DbContextOptions<ComplaintDbContext> options) : base(options)
		{

		}

		public DbSet<Complaint> Complaints { get; set; }
	}

}
