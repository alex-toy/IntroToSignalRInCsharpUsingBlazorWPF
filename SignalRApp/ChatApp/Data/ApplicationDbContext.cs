using ChatApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
	public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			builder.Entity<Message>()
				.HasOne<AppUser>(m => m.Sender)
				.WithMany(au => au.Messages)
				.HasForeignKey(m => m.UserId);
		}

		public DbSet<Message> Messages { get; set; }
	}
}
