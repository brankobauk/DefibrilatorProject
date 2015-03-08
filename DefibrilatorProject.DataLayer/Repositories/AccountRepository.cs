using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DefibrilatorProject.DataLayer.Context;
using DefibrilatorProject.Models.Models;
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
    }
}
