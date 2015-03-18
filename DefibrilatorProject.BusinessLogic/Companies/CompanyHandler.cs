using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DefibrilatorProject.BusinessLogic.DropDowns;
using DefibrilatorProject.Models.Models;
using DefibrilatorProject.Models.ViewModels;

namespace DefibrilatorProject.BusinessLogic.Companies
{
    public class CompanyHandler
    {
        private readonly CompanyManager _companyManager = new CompanyManager();
        private readonly DropDownManager _dropDownManager = new DropDownManager();
        public List<Company> GetCompanies()
        {
            return _companyManager.GetCompanies();
        }

        public void AddCompany(Company company)
        {
            _companyManager.AddCompany(company);
        }

        public void EditCompany(int id, Company company)
        {
            _companyManager.EditCompany(id, company);
        }

        public void DeleteCompany(int id)
        {
            _companyManager.DeleteCompany(id);
        }

        public Company GetCompany(int id)
        {
            return _companyManager.GetCompany(id);
        }

        public MaintenanceViewModel GetCompaniesForDropDown()
        {
            return new MaintenanceViewModel()
            {
                Companies = _dropDownManager.GetCompanyListForDropDown(_companyManager.GetCompanies())
            };
        }
    }
}
