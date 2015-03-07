using System.Collections.Generic;
using DefibrilatorProject.DataLayer.Filters;
using DefibrilatorProject.DataLayer.Repositories;
using DefibrilatorProject.Models.Models;

namespace DefibrilatorProject.BusinessLogic.AccountManager
{
    
    public class AccountManager
    {
        private readonly InitializeDatabaseConnection _initializeDatabaseConnection = new InitializeDatabaseConnection();
        private readonly AccountRepository _accountRepository = new AccountRepository();
        public void InitializeSimpleMembership()
        {
            _initializeDatabaseConnection.SimpleMembershipInitializer();
        }

        public bool Login(LoginModel model)
        {
            return _accountRepository.Login(model);
        }

        public void Logout()
        {
            _accountRepository.Logout();
        }

        public void CreateUser(RegisterModel model)
        {
            _accountRepository.CreateUser(model);
        }

        public List<UserProfile> GetUsers()
        {
            var users = _accountRepository.GetUsers();
            return users;
        }
    }
}
