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
        private readonly CompanyManager _companyManager = new CompanyManager();
        //
        // GET: /Company/

        public ActionResult Index()
        {
            return View(_companyManager.GetCompanies());
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
                _companyManager.AddCompany(company);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            
            return View(_companyManager.GetCompany(id));
        }

        [HttpPost]
        public ActionResult Edit(int id, Company company)
        {
            try
            {
                _companyManager.EditCompany(id, company);
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
                _companyManager.DeleteCompany(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }
    }
}
