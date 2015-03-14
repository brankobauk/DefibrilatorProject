using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DefibrilatorProject.BusinessLogic.Maintenances;

namespace DefibrilatorProject.UI.Controllers
{
    public class MaintenanceController : Controller
    {
        private readonly MaintenanceManager _maintenanceManager = new MaintenanceManager();
        public ActionResult Index()
        {
            var productId = Convert.ToInt32(Request.QueryString["ProductId"]);
            var companyId = Convert.ToInt32(Request.QueryString["CompanyId"]);
            return View(_maintenanceManager.GetMaintenanceItems(productId, companyId));
        }

        //
        // GET: /Maintenance/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Maintenance/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Maintenance/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Maintenance/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Maintenance/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

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
