using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using View.Models;

namespace View.DAL
{
    public class PokeDBContext : DbContext
    {
        public DbSet<Type> Types { get; set; }
        public DbSet<Pokemon> Pokemons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}