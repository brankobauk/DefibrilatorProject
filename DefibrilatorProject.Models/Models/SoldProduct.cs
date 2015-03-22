using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DefibrilatorProject.Models.Models
{
    public class SoldProduct
    {
        public SoldProduct()
        {
            Maintenance = new List<Maintenance>();
        }
        [Key]
        public int SoldProductId { get; set; }
        public int ProductId { get; set; }
        public int CompanyId { get; set; }
        public string Location { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime SoldDate { get; set; }
        public bool StopMaintenance { get; set; }
        public virtual Company Company { get; set; }
        public virtual Product Product { get; set; }
        private ICollection<Maintenance> Maintenance { get; set; }
    }
}
