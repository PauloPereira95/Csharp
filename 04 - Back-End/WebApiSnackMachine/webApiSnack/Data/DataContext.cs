global using Microsoft.EntityFrameworkCore;
using webApiSnack.Models;

namespace webApiSnack.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=dbapisnack;Trusted_Connection=true;TrustServerCertificate=true;");
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Money> Money { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>()
                .HasOne(c => c.Money)
                .WithOne(c => c.Customer)
                .HasForeignKey<Money>(c => c.IDMoney);
        }
    }
}
