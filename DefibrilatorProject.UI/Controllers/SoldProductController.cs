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
using NLog;

namespace DefibrilatorProject.UI.Controllers
{
    public class SoldProductController : Controller
    {
        //
        // GET: /SoldProduct/
        private readonly SoldProductHandler _soldProductHandler = new SoldProductHandler();
        public ActionResult Index()
        {
            return View(_soldProductHandler.GetSoldProducts());
        }

        //
        // GET: /SoldProduct/Create

        public ActionResult Create()
        {
            return View(_soldProductHandler.CreateSoldProduct());
        }

        //
        // POST: /SoldProduct/Create

        [HttpPost]
        public ActionResult Create(SoldProduct soldProduct)
        {
            try
            {
                _soldProductHandler.AddSoldProduct(soldProduct);
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Error = "Item Was Not Saved. Please Try Again!";
                return View(_soldProductHandler.CreateSoldProduct());
            }
        }

        //
        // GET: /SoldProduct/Edit/5

        public ActionResult Edit(int soldProductId)
        {
            return View(_soldProductHandler.GetSoldProduct(soldProductId));
        }

        //
        // POST: /SoldProduct/Edit/5

        [HttpPost]
        public ActionResult Edit(SoldProduct soldProduct)
        {
            try
            {
                _soldProductHandler.EditSoldProduct(soldProduct);
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
            _soldProductHandler.Delete(soldProductId);
            return RedirectToAction("Index");
        }

        public PartialViewResult CreateDropDown()
        {
            var companyIdQs = Request.QueryString["CompanyId"];
            int companyId = 0;
            if (!string.IsNullOrEmpty(companyIdQs))
            {
                companyId = Convert.ToInt32(companyIdQs);
            }
            return PartialView("_SoldProductDropDown", _soldProductHandler.GetSoldProductListForDropDownWithEmptyItem(companyId));
        }
    }
}
