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
            
                items = items.Where(
                    p => p.DateOfMainenance.AddMonths(p.ProductProperty.ServiceRate) < DateTime.Now.AddMonths(1) && p.SoldProduct.StopMaintenance == false && p.ProductProperty.StopMaintenance == false).ToList();
            return
                items.GroupBy(p => new {p.SoldProductId, p.ProductPropertyId})
                    .Select(g => g.OrderByDescending(p => p.DateOfMainenance)
                        .FirstOrDefault()).ToList();
        }
    }
}
