using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DefibrilatorProject.BusinessLogic.Companies;
using DefibrilatorProject.Models.Models;

namespace DefibrilatorProject.UI.Controllers
{
    [Authorize]
    public class CompanyController : Controller
    {
        private readonly CompanyHandler _companyHandler = new CompanyHandler();
     
        //
        // GET: /Company/

        public ActionResult Index()
        {
            return View(_companyHandler.GetCompanies());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Company company)
        {
            try
            {
                _companyHandler.AddCompany(company);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {

            return View(_companyHandler.GetCompany(id));
        }

        [HttpPost]
        public ActionResult Edit(int id, Company company)
        {
            try
            {
                _companyHandler.EditCompany(id, company);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        public ActionResult Delete(int id)
        {
            try
            {
                _companyHandler.DeleteCompany(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }
        public PartialViewResult CreateDropDown()
        {
            return PartialView("_CompanyDropDown", _companyHandler.GetCompaniesForDropDown());
        }
    }
}
