using System.Collections.Generic;
using DefibrilatorProject.DataLayer.Repositories;
using DefibrilatorProject.Models.Models;

namespace DefibrilatorProject.BusinessLogic.Companies
{
    public class CompanyManager
    {
        private readonly CompanyRepository _companyRepository = new CompanyRepository();
        public List<Company> GetCompanies()
        {
            return _companyRepository.GetCompanies();
        }

        public void AddCompany(Company company)
        {
            _companyRepository.AddCompany(company);
        }

        public void EditCompany(int id, Company company)
        {
            _companyRepository.EditCompany(id, company);
        }

        public void DeleteCompany(int id)
        {
            _companyRepository.DeleteCompany(id);
        }

        public Company GetCompany(int id)
        {
            return _companyRepository.GetCompany(id);
        }
    }
}
