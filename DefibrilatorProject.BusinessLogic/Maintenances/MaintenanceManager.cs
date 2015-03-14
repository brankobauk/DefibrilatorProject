using System;
using System.Collections.Generic;
using System.Linq;
using DefibrilatorProject.BusinessLogic.Companies;
using DefibrilatorProject.BusinessLogic.Products;
using DefibrilatorProject.BusinessLogic.SoldProducts;
using DefibrilatorProject.DataLayer.Repositories;
using DefibrilatorProject.Models.Models;
using DefibrilatorProject.Models.ViewModels;

namespace DefibrilatorProject.BusinessLogic.Maintenances
{
    public class MaintenanceManager
    {
        private readonly MaintenanceRepository _maintenanceRepository = new MaintenanceRepository();
        private readonly ProductManager _productManager = new ProductManager();
        //private readonly SoldProductManager _soldProductManager = new SoldProductManager();
        //private readonly CompanyManager _companyManager = new CompanyManager();
        public List<Maintenance> GetMaintenanceItems(int productId, int companyId)
        {
            var maintenanceItems = _maintenanceRepository.GetMaintenanceItems(); 
            if(productId > 0)
                maintenanceItems = maintenanceItems.Where(p => p.SoldProduct.ProductId == productId).ToList();
            if(companyId > 0)
                maintenanceItems = maintenanceItems.Where(p => p.SoldProduct.CompanyId == companyId).ToList();
            return maintenanceItems;
            //return new MaintenanceViewModel()
            //{
            //    Maintenances = maintenanceItems,
            //    SoldProducts = _soldProductManager.GetSoldProducts(),
            //    Products = _productManager.GetProducts(),
            //    Companies = _companyManager.GetCompanies()
            //};
        }

        public void AddNewSoldProduct(SoldProduct soldProduct)
        {
            var productProperties = _productManager.GetProductPropertyByProductId(soldProduct.ProductId);
            foreach (var productProperty in productProperties)
            {
                var maintenanceItem = new Maintenance()
                {
                    SoldProductId = soldProduct.SoldProductId,
                    ProductPropertyId = productProperty.ProductPropertyId,
                    Notes = "Product Sold",
                    DateOfMainenance = DateTime.UtcNow
                };
                _maintenanceRepository.AddMaintenanceItem(maintenanceItem);
            }
            
        }
    }
}
