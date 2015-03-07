using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DefibrilatorProject.DataLayer.Context;
using WebMatrix.WebData;

namespace DefibrilatorProject.DataLayer.Filters
{
    public class InitializeDatabaseConnection
    {
        private readonly DefibrilatorProjectContext _defibrilatorProjectContext = new DefibrilatorProjectContext();
        public void SimpleMembershipInitializer()
        {
            Database.SetInitializer<DefibrilatorProjectContext>(null);

            try
            {
                if (!_defibrilatorProjectContext.Database.Exists())
                {
                    // Create the SimpleMembership database without Entity Framework migration schema
                    ((IObjectContextAdapter)_defibrilatorProjectContext).ObjectContext.CreateDatabase();
                    WebSecurity.InitializeDatabaseConnection("DefibrilatorProjectContext", "UserProfiles", "UserId", "UserName", autoCreateTables: true);
                }
                
                
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("The ASP.NET Simple Membership database could not be initialized. For more information, please see http://go.microsoft.com/fwlink/?LinkId=256588", ex);
            }
        }
    }
}
