using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DefibrilatorProject.BusinessLogic.Companies;
using DefibrilatorProject.BusinessLogic.DropDowns;
using DefibrilatorProject.BusinessLogic.Products;
using DefibrilatorProject.BusinessLogic.SoldProducts;
using DefibrilatorProject.DataLayer.Repositories;
using DefibrilatorProject.Models.Models;
using DefibrilatorProject.Models.ViewModels;

namespace DefibrilatorProject.BusinessLogic.Maintenances
{
    public class MaintenanceHandler
    {
        private readonly MaintenanceManager _maintenanceManager = new MaintenanceManager();
        private readonly DropDownManager _dropDownManager = new DropDownManager();
        private readonly ProductManager _productManager = new ProductManager();
        private readonly CompanyManager _companyManager = new CompanyManager();
        private readonly SoldProductManager _soldProductManager = new SoldProductManager();
        public MaintenanceViewModel GetMaintenanceItems(int productId, int companyId)
        {
            var maintenanceItems = _maintenanceManager.GetMaintenanceItems();
            if (productId > 0)
                maintenanceItems = maintenanceItems.Where(p => p.SoldProduct.ProductId == productId).ToList();
            if (companyId > 0)
                maintenanceItems = maintenanceItems.Where(p => p.SoldProduct.CompanyId == companyId).ToList();
            //return maintenanceItems;
            return new MaintenanceViewModel()
            {
                Maintenances = maintenanceItems,
                Products = _dropDownManager.GetProductListForDropDownWithEmptyItem(_productManager.GetProducts()),
                Companies = _dropDownManager.GetCompanyListForDropDownWithEmptyItem(_companyManager.GetCompanies()),
                ProductId = productId,
                CompanyId = companyId
            };
        }


        public MaintenanceViewModel CreateMaintenanceItem()
        {
            return new MaintenanceViewModel()
            {
                Companies = _dropDownManager.GetCompanyListForDropDownWithEmptyItem(_companyManager.GetCompanies())
            };
        }

        public void AddMaintenanceItem(Maintenance maintenance)
        {
           _maintenanceManager.AddMaintenanceItem(maintenance);
        }

        public MaintenanceViewModel GetMaintenanceItem(int maintenanceId)
        {
            var maintenanceItem = _maintenanceManager.GetMaintenanceItem(maintenanceId);
            var soldProduct = _soldProductManager.GetSoldProduct(maintenanceItem.SoldProductId);
            return new MaintenanceViewModel()
            {
                Maintenance = maintenanceItem,
                Companies = _dropDownManager.GetCompanyListForDropDownWithEmptyItem(_companyManager.GetCompanies()),
                SoldProducts = _dropDownManager.GetSoldProductListForDropDownWithEmptyItem(_soldProductManager.GetSoldProducts().Where(p => p.CompanyId == soldProduct.CompanyId).ToList()),
                ProductProperties = _dropDownManager.GetProductPropertyForDropDownWithEmptyItem(_productManager.GetProductPropertyByProductId(soldProduct.ProductId)),
                CompanyId = soldProduct.CompanyId
            };
        }

        public void EditMaintenanceItem(Maintenance maintenance)
        {
            _maintenanceManager.EditMaintenance(maintenance);
        }
    }
}
