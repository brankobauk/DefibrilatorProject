using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DefibrilatorProject.Models.Models;

namespace DefibrilatorProject.Models.ViewModels
{
    public class ProductViewModel
    {
        public Product Product { get; set; }
        public List<ProductProperty> ProductProperties { get; set; }
    }
}
