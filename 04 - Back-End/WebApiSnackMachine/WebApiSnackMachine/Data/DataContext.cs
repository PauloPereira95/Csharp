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
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Money> Money { get; set; }
        public DbSet<Intervection> Intervection { get; set; }
        public DbSet<Machine> Machine { get; set; }
        public DbSet<Orders> Order { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Support> Support { get; set; }

       
    }
}
