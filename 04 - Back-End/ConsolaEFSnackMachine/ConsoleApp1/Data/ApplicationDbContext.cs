using ConsoleSnackMachine.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnackMachine.Data
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration config = builder.Build();

            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(config.GetConnectionString("SqlServer"));
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<ProductSupplier> ProductSupplier { get; set; }
        //protected override void OnModelCreating(ModelBuilder mb)
        //{
        //    mb.Entity<Employee>()
        //    .ToTable(“tblEmployees”)
        //    .HasKey(k => k.Id);
        //}
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ProductSupplier>()
                .HasMany(p => p.Products).WithMany(s => s.Suppliers);
        }


    }
}
