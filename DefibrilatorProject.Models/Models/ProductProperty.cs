using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DefibrilatorProject.Models.Models
{
    public class ProductProperty
    {
        [Key]
        public int ProductPropertyId { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}