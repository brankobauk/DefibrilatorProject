using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DefibrilatorProject.Models.Models
{
    public class Product
    {
        public Product()
        {
            ProductProperty = new List<ProductProperty>();
        }
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string SerialCode { get; set; }
        private ICollection<ProductProperty> ProductProperty { get; set; }
    }
}