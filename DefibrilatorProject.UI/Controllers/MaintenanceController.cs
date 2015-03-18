using System;
using System.Web.Mvc;
using DefibrilatorProject.BusinessLogic.Maintenances;
using DefibrilatorProject.Models.Models;

namespace DefibrilatorProject.UI.Controllers
{
    public class MaintenanceController : Controller
    {
        private readonly MaintenanceHandler _maintenanceHandler = new MaintenanceHandler();
        public ActionResult Index()
        {
            var productIdQs = Request.QueryString["ProductId"];
            int productId = 0;
            if (!string.IsNullOrEmpty(productIdQs))
            {
                productId = Convert.ToInt32(productIdQs);
            }
            var companyIdQs = Request.QueryString["CompanyId"];
            int companyId = 0;
            if (!string.IsNullOrEmpty(companyIdQs))
            {
                companyId = Convert.ToInt32(companyIdQs);
            }

            return View(_maintenanceHandler.GetMaintenanceItems(productId, companyId));
        }

        //
        // GET: /Maintenance/Create

        public ActionResult Create()
        {
            return View(_maintenanceHandler.CreateMaintenanceItem());
        }

        //
        // POST: /Maintenance/Create

        [HttpPost]
        public ActionResult Create(Maintenance maintenance)
        {
            try
            {
                _maintenanceHandler.AddMaintenanceItem(maintenance);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        //
        // GET: /Maintenance/Edit/5

        public ActionResult Edit(int maintenanceId)
        {
            return View(_maintenanceHandler.GetMaintenanceItem(maintenanceId));
        }

        //
        // POST: /Maintenance/Edit/5

        [HttpPost]
        public ActionResult Edit(Maintenance maintenance)
        {
            try
            {
                // TODO: Add update logic here
                _maintenanceHandler.EditMaintenanceItem(maintenance);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Maintenance/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Maintenance/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
