using System;
using System.ComponentModel.DataAnnotations;

namespace DefibrilatorProject.Models.Models
{
    public class Maintenance
    {
        public int MaintenanceId { get; set; }
        public int SoldProductId { get; set; }
        public int ProductPropertyId { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime DateOfMainenance { get; set; }
        public string Notes { get; set; }
        public virtual SoldProduct SoldProduct { get; set; }
        public virtual ProductProperty ProductProperty { get; set; }
    }
}
