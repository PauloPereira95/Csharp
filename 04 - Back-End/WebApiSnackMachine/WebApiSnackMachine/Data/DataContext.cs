using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using WebApiSnackMachine.Models;

namespace WebApiSnackMachine.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=db_snack_teste;Trusted_Connection=true;TrustServerCertificate=true;");
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Money> Money { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Customer>()
        //        .HasOne(m => m.Money)
        //        .WithOne(c => c.Customer)
        //        .HasForeignKey<Money>(m => m.IDCostumer);
        //    modelBuilder.Entity<Money>()
        //        .HasOne(m => m.Customer)
        //        .WithOne(c => c.Money)
        //        .HasForeignKey<Customer>(m => m.IDMoney);
        //}
    }
}
