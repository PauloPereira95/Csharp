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
        public DbSet<Costumer> Costumer { get; set; }
        public DbSet<Intervetion> Intervetion { get; set; }
        public DbSet<Machine> Machine { get; set; }
        public DbSet<Money> Money { get; set; }
        public DbSet<Orders> Order { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Support> Support { get; set; }

        //protected override void OnModelCreating(ModelBuilder mb)
        //{

        //    mb.Entity<Product>()
        //        .HasMany(p => p.Positions)
        //        .WithMany(po => po.Product);
        //    mb.Entity<Machine>()
        //        .HasMany(i => i.Intervetion)
        //        .WithMany(m => m.Machine);
        //    mb.Entity<Machine>()
        //        .HasMany(p => p.Position)
        //        .WithMany(m => m.Machine);
        //    mb.Entity<Machine>()
        //       .HasMany(p => p.Product)
        //       .WithMany(m => m.Machine);
        //    mb.Entity<Machine>()
        //       .HasMany(p => p.Product)
        //       .WithMany(m => m.Machine);
        //    mb.Entity<Product>()
        //       .HasMany(s => s.Supplier)
        //       .WithMany(p => p.Product);
        //}
    }
    
}
