using System.Data.Entity;
using System.Data.Entity.Migrations;
using DefibrilatorProject.DataLayer.Context;

namespace DefibrilatorProject.DataLayer.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DefibrilatorProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DefibrilatorProjectContext context)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DefibrilatorProjectContext, Configuration>());
            new DefibrilatorProjectContext().UserProfiles.Find(1);
        }

    }
}