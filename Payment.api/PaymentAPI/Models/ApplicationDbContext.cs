using Microsoft.EntityFrameworkCore;
using PaymentAPI.Configurations;

namespace PaymentAPI.Models
{
    public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new PaymentTypeConfigurations().Configure(modelBuilder.Entity<PaymentDetail>());
        }
        public DbSet<PaymentDetail> Payments { get; set; }
    }
}
