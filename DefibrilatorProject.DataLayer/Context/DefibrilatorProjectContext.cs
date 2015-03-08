using System.Data.Entity;
using DefibrilatorProject.DataLayer.Migrations;
using DefibrilatorProject.Models.Models;

namespace DefibrilatorProject.DataLayer.Context
{
    public class DefibrilatorProjectContext : DbContext
    {
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductProperty> ProductProperty { get; set; }
        public DefibrilatorProjectContext()
        {
            Database.SetInitializer<DefibrilatorProjectContext>(null);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DefibrilatorProjectContext, Configuration>());
        }

    }
}
