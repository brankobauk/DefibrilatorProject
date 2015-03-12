using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DefibrilatorProject.BusinessLogic.Companies;
using DefibrilatorProject.BusinessLogic.Products;
using DefibrilatorProject.BusinessLogic.SoldProducts;
using DefibrilatorProject.Models.Models;
using DefibrilatorProject.Models.ViewModels;

namespace DefibrilatorProject.UI.Controllers
{
    public class SoldProductController : Controller
    {
        //
        // GET: /SoldProduct/
        private readonly SoldProductManager _soldProductManager = new SoldProductManager();
        public ActionResult Index()
        {
            return View(_soldProductManager.GetSoldProducts());
        }

        //
        // GET: /SoldProduct/Create

        public ActionResult Create()
        {
            return View(_soldProductManager.CreateSoldProduct());
        }

        //
        // POST: /SoldProduct/Create

        [HttpPost]
        public ActionResult Create(SoldProduct soldProduct)
        {
            try
            {
                _soldProductManager.AddSoldProduct(soldProduct);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /SoldProduct/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /SoldProduct/Edit/5

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
        // GET: /SoldProduct/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /SoldProduct/Delete/5

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
