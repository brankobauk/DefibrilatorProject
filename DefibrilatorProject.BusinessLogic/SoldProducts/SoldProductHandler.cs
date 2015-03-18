using System;
using System.Collections.Generic;
using System.Linq;
using DefibrilatorProject.BusinessLogic.Companies;
using DefibrilatorProject.BusinessLogic.DropDowns;
using DefibrilatorProject.BusinessLogic.Maintenances;
using DefibrilatorProject.BusinessLogic.Products;
using DefibrilatorProject.DataLayer.Repositories;
using DefibrilatorProject.Models.Models;
using DefibrilatorProject.Models.ViewModels;

namespace DefibrilatorProject.BusinessLogic.SoldProducts
{
    public class SoldProductHandler
    {
        private readonly SoldProductManager _soldProductManager = new SoldProductManager();
        private readonly ProductManager _productManager = new ProductManager();
        private readonly CompanyManager _companyManager = new CompanyManager();
        private readonly DropDownManager _dropDownManager = new DropDownManager();
        private readonly MaintenanceManager _maintenanceManager = new MaintenanceManager();
        private readonly ProductPropertyManager _productPropertyManager = new ProductPropertyManager();
        public List<SoldProduct> GetSoldProducts()
        {
            return _soldProductManager.GetSoldProducts();
        }

        public SoldProductViewModel CreateSoldProduct()
        {
            return new SoldProductViewModel()
            {
                SoldProduct = new SoldProduct()
                {
                    SoldDate = DateTime.Now
                },
                Products = _dropDownManager.GetProductListForDropDown(_productManager.GetProducts()),
                Companies = _dropDownManager.GetCompanyListForDropDown(_companyManager.GetCompanies())
            };
        }

        public void AddSoldProduct(SoldProduct soldProduct)
        {
            _soldProductManager.AddSoldProduct(soldProduct);
            var productProperties = _productPropertyManager.GetProductPropertyByProductId(soldProduct.ProductId);
            foreach (var productProperty in productProperties)
            {
                var maintenanceItem = new Maintenance()
                {
                    SoldProductId = soldProduct.SoldProductId,
                    ProductPropertyId = productProperty.ProductPropertyId,
                    Notes = "ProductSold",
                    DateOfMainenance = DateTime.UtcNow
                };
                _maintenanceManager.AddMaintenanceItem(maintenanceItem);
            }
        }

        public SoldProductViewModel GetSoldProduct(int soldProductId)
        {
            return new SoldProductViewModel()
            {
                SoldProduct = _soldProductManager.GetSoldProduct(soldProductId),
                Products = _dropDownManager.GetProductListForDropDown(_productManager.GetProducts()),
                Companies = _dropDownManager.GetCompanyListForDropDown(_companyManager.GetCompanies())
            };
        }

        public void EditSoldProduct(SoldProduct soldProduct)
        {
            _soldProductManager.EditSoldProduct(soldProduct);
        }

        public void Delete(int soldProductId)
        {
            _soldProductManager.Delete(soldProductId);
        }

        public MaintenanceViewModel GetSoldProductListForDropDownWithEmptyItem(int companyId)
        {
            return new MaintenanceViewModel()
            {
                SoldProducts = _dropDownManager.GetSoldProductListForDropDownWithEmptyItem(_soldProductManager.GetSoldProducts().Where(p => p.CompanyId == companyId).ToList())
            };
        }
    }
}
