using System.Collections.Generic;
using System.Web.Mvc;
using DefibrilatorProject.Models.Models;

namespace DefibrilatorProject.Models.ViewModels
{
    public class MaintenanceViewModel
    {
        public Maintenance Maintenance { get; set; }
        public IEnumerable<Maintenance> Maintenances { get; set; }
        public IEnumerable<SelectListItem> Products { get; set; }
        public IEnumerable<SelectListItem> Companies { get; set; }
        public IEnumerable<SelectListItem> SoldProducts { get; set; }
        public IEnumerable<SelectListItem> ProductProperties { get; set; }
        public int ProductId { get; set; } 
        public int CompanyId { get; set; }
    }
}
