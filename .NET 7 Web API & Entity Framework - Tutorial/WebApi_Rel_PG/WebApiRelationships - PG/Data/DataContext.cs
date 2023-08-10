using Microsoft.EntityFrameworkCore;
using WebApiRelationships___PG.Models;

namespace WebApiRelationships___PG.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Character> Character { get; set; }
        public DbSet<Backpack> Backpacks { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Faction> Factions { get; set; }
    }
}
