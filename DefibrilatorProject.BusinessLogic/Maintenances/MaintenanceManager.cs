using System;
using System.Collections.Generic;
using System.Linq;
using DefibrilatorProject.BusinessLogic.Companies;
using DefibrilatorProject.BusinessLogic.DropDowns;
using DefibrilatorProject.BusinessLogic.Products;
using DefibrilatorProject.BusinessLogic.SoldProducts;
using DefibrilatorProject.DataLayer.Repositories;
using DefibrilatorProject.Helpers.DropDownHelpers;
using DefibrilatorProject.Models.Models;
using DefibrilatorProject.Models.ViewModels;

namespace DefibrilatorProject.BusinessLogic.Maintenances
{
    public class MaintenanceManager
    {
        private readonly MaintenanceRepository _maintenanceRepository = new MaintenanceRepository();

        public IEnumerable<Maintenance> GetMaintenanceItems()
        {
            return _maintenanceRepository.GetMaintenanceItems();
        }

        public void AddMaintenanceItem(Maintenance maintenanceItem)
        {
            _maintenanceRepository.AddMaintenanceItem(maintenanceItem);
        }

        public Maintenance GetMaintenanceItem(int maintenanceId)
        {
            return _maintenanceRepository.GetMaintenanceItem(maintenanceId);
        }

        public void EditMaintenance(Maintenance maintenanceItem)
        {
            _maintenanceRepository.EditMaintenance(maintenanceItem);
        }

        public List<Maintenance> GetItemsToService()
        {
            var items = _maintenanceRepository.GetMaintenanceItems();
            return
                items.Where(
                    p => p.DateOfMainenance.AddMonths(p.ProductProperty.ServiceRate) < DateTime.Now.AddMonths(1)).ToList();
        }
    }
}
