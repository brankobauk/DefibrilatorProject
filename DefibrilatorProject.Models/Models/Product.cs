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
            SoldProducts = new List<SoldProduct>();
        }
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public  ICollection<ProductProperty> ProductProperty { get; set; }
        private ICollection<SoldProduct> SoldProducts { get; set; }
    }
}