using System;
using System.ComponentModel.DataAnnotations;

namespace DefibrilatorProject.Models.Models
{
    public class SoldProduct
    {
        [Key]
        public int SoldProductId { get; set; }
        public int ProductId { get; set; }
        public int CompanyId { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime SoldDate { get; set; }
        public virtual Company Company { get; set; }
        public virtual Product Product { get; set; }
    }
}
