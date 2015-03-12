using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DefibrilatorProject.DataLayer.Context;
using DefibrilatorProject.Models.Models;

namespace DefibrilatorProject.DataLayer.Repositories
{
    public class CompanyRepository
    {
        private readonly DefibrilatorProjectContext _db = new DefibrilatorProjectContext();

        public List<Company> GetCompanies()
        {
            return _db.Company.ToList();
        }

        public void AddCompany(Company company)
        {
            _db.Company.Add(company);
            _db.SaveChanges();
        }

        public void EditCompany(int id, Company company)
        {
            var companyToEdit = GetCompany(id);
            if (companyToEdit == null) return;
            companyToEdit.Name = company.Name;
            _db.SaveChanges();
        }

        public void DeleteCompany(int id)
        {
            var companyToDelete = GetCompany(id);
            _db.Company.Remove(companyToDelete);
            _db.SaveChanges();
        }

        public Company GetCompany(int id)
        {
            return _db.Company.FirstOrDefault(p => p.CompanyId == id);
        }
    }
}
