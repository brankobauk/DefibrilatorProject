using System.Collections.Generic;
using DefibrilatorProject.DataLayer.Filters;
using DefibrilatorProject.DataLayer.Repositories;
using DefibrilatorProject.Helpers.DropDownHelpers;
using DefibrilatorProject.Models.Models;
using DefibrilatorProject.Models.ViewModels;

namespace DefibrilatorProject.BusinessLogic.Accounts
{
    
    public class AccountManager
    {
        private readonly InitializeDatabaseConnection _initializeDatabaseConnection = new InitializeDatabaseConnection();
        private readonly DropdownHelper _dropdownHelper = new DropdownHelper();
        private readonly AccountRepository _accountRepository = new AccountRepository();
        private readonly CompanyRepository _companyRepository = new CompanyRepository();
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
            return  _accountRepository.GetUsers();
        }

        public AccountViewModel GetUser(int userId)
        {
            return new AccountViewModel()
            {
                UserProfile = _accountRepository.GetUser(userId),
                Companies = _dropdownHelper.GetCompanyListForDropDown(_companyRepository.GetCompanies())
            };
        }

        public void EditUser(int userId, AccountViewModel accountViewModel)
        {
            _accountRepository.EditUser(userId, accountViewModel);
        }

        public void DeleteUser(int userId)
        {
            _accountRepository.DeleteUser(userId);
        }
    }
}
