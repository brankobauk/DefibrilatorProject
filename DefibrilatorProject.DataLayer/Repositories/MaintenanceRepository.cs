using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DefibrilatorProject.DataLayer.Context;
using DefibrilatorProject.Models.Models;

namespace DefibrilatorProject.DataLayer.Repositories
{
    public class MaintenanceRepository
    {
        private readonly DefibrilatorProjectContext _db = new DefibrilatorProjectContext();
        public List<Maintenance> GetMaintenanceItems()
        {
            return _db.Maintenance.ToList();
        }

        public void AddMaintenanceItem(Maintenance maintenanceItem)
        {
            _db.Maintenance.Add(maintenanceItem);
            _db.SaveChanges();
        }

        public Maintenance GetMaintenanceItem(int maintenanceId)
        {
            return _db.Maintenance.FirstOrDefault(p => p.MaintenanceId == maintenanceId);
        }

        public void EditMaintenance(Maintenance maintenance)
        {
            var maintenanceItem = GetMaintenanceItem(maintenance.MaintenanceId);
            maintenanceItem.SoldProductId = maintenance.SoldProductId;
            maintenanceItem.ProductPropertyId = maintenance.ProductPropertyId;
            maintenanceItem.DateOfMainenance = maintenance.DateOfMainenance;
            maintenanceItem.Notes = maintenance.Notes;
            _db.SaveChanges();
        }
    }
}
