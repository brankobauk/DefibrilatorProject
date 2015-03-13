using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DefibrilatorProject.BusinessLogic.Companies;
using DefibrilatorProject.BusinessLogic.Maintenances;
using DefibrilatorProject.BusinessLogic.Products;
using DefibrilatorProject.DataLayer.Repositories;
using DefibrilatorProject.Helpers.DropDownHelpers;
using DefibrilatorProject.Models.Models;
using DefibrilatorProject.Models.ViewModels;

namespace DefibrilatorProject.BusinessLogic.SoldProducts
{
    public class SoldProductManager
    {
        private readonly SoldProductRepository _soldProductRepository = new SoldProductRepository();
        private readonly ProductManager _productManager = new ProductManager();
        private readonly CompanyManager _companyManager = new CompanyManager();
        private readonly DropdownHelper _dropdownHelper = new DropdownHelper();
        private readonly MaintenanceManager _maintenanceManager = new MaintenanceManager();
        public List<SoldProduct> GetSoldProducts()
        {
            return _soldProductRepository.GetSoldProducts();
        }

        public SoldProductViewModel CreateSoldProduct()
        {
            return new SoldProductViewModel()
            {
                SoldProduct = new SoldProduct()
                {
                    SoldDate = DateTime.UtcNow
                },
                Products = _dropdownHelper.GetProductListForDropDown(_productManager.GetProducts()),
                Companies = _dropdownHelper.GetCompanyListForDropDown(_companyManager.GetCompanies())
            };
        }

        public void AddSoldProduct(SoldProduct soldProduct)
        {
            _soldProductRepository.AddSoldProduct(soldProduct);
            _maintenanceManager.AddNewSoldProduct(soldProduct);
        }

        public SoldProductViewModel GetSoldProduct(int soldProductId)
        {
            return new SoldProductViewModel()
            {
                SoldProduct = _soldProductRepository.GetSoldProduct(soldProductId),
                Products = _dropdownHelper.GetProductListForDropDown(_productManager.GetProducts()),
                Companies = _dropdownHelper.GetCompanyListForDropDown(_companyManager.GetCompanies())
            };
        }

        public void EditSoldProduct(SoldProduct soldProduct)
        {
            _soldProductRepository.EditSoldProduct(soldProduct);
        }

        public void Delete(int soldProductId)
        {
            _soldProductRepository.Delete(soldProductId);
        }
    }
}
