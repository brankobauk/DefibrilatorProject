using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DefibrilatorProject.DataLayer.Filters;

namespace DefibrilatorProject.BusinessLogic.AccountManager
{
    
    public class AccountManager
    {
        private readonly InitializeDatabaseConnection _initializeDatabaseConnection = new InitializeDatabaseConnection();
        public void InitializeSimpleMembership()
        {
            _initializeDatabaseConnection.SimpleMembershipInitializer();
        }
    }
}
