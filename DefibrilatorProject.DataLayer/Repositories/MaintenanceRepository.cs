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
    }
}
