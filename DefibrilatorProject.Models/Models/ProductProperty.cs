using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DefibrilatorProject.Models.Models
{
    public class ProductProperty
    {
        public ProductProperty()
        {
            Maintenance = new List<Maintenance>();
        }
        [Key]
        public int ProductPropertyId { get; set; }
        public string Name { get; set; }
        public int ServiceRate { get; set; }
        public bool StopMaintenance { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        private ICollection<Maintenance> Maintenance { get; set; }
    }
}