using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DefibrilatorProject.BusinessLogic.Maintenances;

namespace DefibrilatorProject.UI.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly MaintenanceHandler _maintenanceHandler = new MaintenanceHandler();
        public ActionResult Index()
        {
            return View(_maintenanceHandler.GetItemsToService());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
