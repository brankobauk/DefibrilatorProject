using System.Collections.Generic;
using System.Web.Mvc;
using DefibrilatorProject.Models.Models;

namespace DefibrilatorProject.Models.ViewModels
{
    public class MaintenanceViewModel
    {
        public IEnumerable<Maintenance> Maintenances { get; set; }
        public IEnumerable<SelectListItem> Products { get; set; }
        public IEnumerable<SelectListItem> Companies { get; set; }
        public int ProductId { get; set; } 
        public int CompanyId { get; set; }
    }
}
