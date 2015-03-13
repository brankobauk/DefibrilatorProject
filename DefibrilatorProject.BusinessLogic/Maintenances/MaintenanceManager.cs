using System;
using System.Collections.Generic;
using DefibrilatorProject.BusinessLogic.Products;
using DefibrilatorProject.DataLayer.Repositories;
using DefibrilatorProject.Models.Models;

namespace DefibrilatorProject.BusinessLogic.Maintenances
{
    public class MaintenanceManager
    {
        private readonly MaintenanceRepository _maintenanceRepository = new MaintenanceRepository();
        private readonly ProductManager _productManager = new ProductManager();
        public List<Maintenance> GetMaintenanceItems()
        {
            return _maintenanceRepository.GetMaintenanceItems();
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
                    Notes = "ProductSold",
                    DateOfMainenance = DateTime.Now
                };
                _maintenanceRepository.AddMaintenanceItem(maintenanceItem);
            }
            
        }
    }
}
