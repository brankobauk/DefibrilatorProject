using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DefibrilatorProject.BusinessLogic.ProductManager;
using DefibrilatorProject.Models.Models;
using DefibrilatorProject.Models.ViewModels;

namespace DefibrilatorProject.UI.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductManager _productManager = new ProductManager();
        //
        // GET: /Product/

        public ActionResult Index()
        {
            return View(_productManager.GetProducts());
        }

        //
        // GET: /Product/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Product/Create

        [HttpPost]
        public ActionResult Create(Product product)
        {
            try
            {
                _productManager.AddProduct(product);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        //
        // GET: /Product/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Product/Edit/5

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
        // GET: /Product/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Product/Delete/5

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
        #region Partials
        public PartialViewResult NewClientRow()
        {
            return PartialView("_ProductPropertyRow", new ProductProperty());
        }
        #endregion
    }
}
