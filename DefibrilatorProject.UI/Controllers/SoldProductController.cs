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
                ViewBag.Error = "Item Was Not Saved. Please Try Again!";
                return View(_soldProductManager.CreateSoldProduct());
            }
        }

        //
        // GET: /SoldProduct/Edit/5

        public ActionResult Edit(int soldProductId)
        {
            return View(_soldProductManager.GetSoldProduct(soldProductId));
        }

        //
        // POST: /SoldProduct/Edit/5

        [HttpPost]
        public ActionResult Edit(SoldProduct soldProduct)
        {
            try
            {
                _soldProductManager.EditSoldProduct(soldProduct);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        //
        // GET: /SoldProduct/Delete/5

        public ActionResult Delete(int soldProductId)
        {
            _soldProductManager.Delete(soldProductId);
            return RedirectToAction("Index");
        }

        
    }
}
