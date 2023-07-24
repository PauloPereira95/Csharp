using EFDataAcessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAcessLibrary.DataAcess
{
    public class PeopleContext : DbContext
    {
        // construtor
        public PeopleContext(DbContextOptions options) : base(options) { }
        // Tabelas
        public DbSet<Person> People { get; set; }
        public DbSet<Address> Adress { get; set; }
        public DbSet<Email> Email { get; set; }

    }
}
