using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefibrilatorProject.Models.Models
{
    public class SoldProduct
    {
        public int SoldProductId { get; set; }
        public int ProductId { get; set; }
        public int CompanyId { get; set; }
        public int SoldDate { get; set; }
    }
}
