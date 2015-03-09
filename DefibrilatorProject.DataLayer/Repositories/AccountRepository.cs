using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DefibrilatorProject.DataLayer.Context;
using DefibrilatorProject.Models.Models;
using DefibrilatorProject.Models.ViewModels;
using WebMatrix.WebData;

namespace DefibrilatorProject.DataLayer.Repositories
{
    public class AccountRepository
    {
        private readonly DefibrilatorProjectContext _db = new DefibrilatorProjectContext();
        public bool Login(LoginModel model)
        {
            return WebSecurity.Login(model.UserName, model.Password, persistCookie: model.RememberMe);
        }

        public void Logout()
        {
            WebSecurity.Logout();
        }

        public void CreateUser(RegisterModel model)
        {
            WebSecurity.CreateUserAndAccount(model.UserName, model.Password);
        }

        public List<UserProfile> GetUsers()
        {
            return _db.UserProfiles.ToList();
                //Where(p => p.CompanyId == p.Company.CompanyId).Include(p => p.Company).ToList();
        }

        public UserProfile GetUser(int userId)
        {
            return _db.UserProfiles.FirstOrDefault(p => p.UserId == userId);
        }

        public void EditUser(int userId, AccountViewModel accountViewModel)
        {
            var userToEdit = GetUser(userId);
            if (userToEdit != null)
            {
                userToEdit.FirstName = accountViewModel.UserProfile.FirstName;
                userToEdit.LastName = accountViewModel.UserProfile.LastName;
                userToEdit.CompanyId = accountViewModel.UserProfile.CompanyId;
                _db.SaveChanges();
            }
        }

        public void DeleteUser(int userId)
        {
            var userToDelete = _db.UserProfiles.FirstOrDefault(p => p.UserId == userId);
            _db.UserProfiles.Remove(userToDelete);
            _db.SaveChanges();
        }
    }
}
