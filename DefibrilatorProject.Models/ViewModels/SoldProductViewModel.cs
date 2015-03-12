using System.Collections.Generic;
using System.Web.Mvc;
using DefibrilatorProject.Models.Models;

namespace DefibrilatorProject.Models.ViewModels
{
    public class SoldProductViewModel
    {
        public SoldProduct SoldProduct { get; set; }
        public IEnumerable<SelectListItem> Products { get; set; }
        public IEnumerable<SelectListItem> Companies { get; set; }
    }
}
