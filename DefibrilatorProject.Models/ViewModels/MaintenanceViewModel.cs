using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DefibrilatorProject.Models.Models;

namespace DefibrilatorProject.Models.ViewModels
{
    public class MaintenanceViewModel
    {
        public List<Maintenance> Maintenances { get; set; }
        public List<SoldProduct> SoldProducts { get; set; }
        public List<Product> Products { get; set; }
        public List<Company> Companies { get; set; }
    }
}
