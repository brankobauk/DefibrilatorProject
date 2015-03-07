using System.Collections.Generic;
using System.Web.Mvc;
using DefibrilatorProject.Models.Models;

namespace DefibrilatorProject.Models.ViewModels
{
    public class AccountViewModel
    {
        public UserProfile UserProfile { get; set; }
        public IEnumerable<SelectListItem> Companies { get; set; }
    }
}
