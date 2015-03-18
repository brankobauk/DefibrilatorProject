using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using DefibrilatorProject.BusinessLogic.Companies;
using DefibrilatorProject.BusinessLogic.Products;
using DefibrilatorProject.Helpers.DropDownHelpers;
using DefibrilatorProject.Models.Models;

namespace DefibrilatorProject.BusinessLogic.DropDowns
{
    public class DropDownManager
    {
        private readonly DropDownHelper _dropDownHelper = new DropDownHelper();
        public IEnumerable<SelectListItem> GetProductListForDropDown(List<Product> products)
        {
            return _dropDownHelper.GetProductListForDropDown(products);
        }

        public IEnumerable<SelectListItem> GetCompanyListForDropDown(List<Company> companies)
        {
            return _dropDownHelper.GetCompanyListForDropDown(companies);
        }

        public IEnumerable<SelectListItem> GetProductListForDropDownWithEmptyItem(List<Product> products)
        {
            return _dropDownHelper.GetProductListForDropDownWithEmptyItem(products);
        }

        public IEnumerable<SelectListItem> GetCompanyListForDropDownWithEmptyItem(List<Company> companies)
        {
            return _dropDownHelper.GetCompanyListForDropDownWithEmptyItem(companies);
        }

        public IEnumerable<SelectListItem> GetSoldProductListForDropDownWithEmptyItem(List<SoldProduct> soldProduct)
        {
            return _dropDownHelper.GetSoldProductListForDropDownWithEmptyItem(soldProduct);
        }

        public IEnumerable<SelectListItem> GetProductPropertyForDropDownWithEmptyItem(List<ProductProperty> productProperties)
        {
            return _dropDownHelper.GetProductPropertyForDropDownWithEmptyItem(productProperties);
        }
    }
}
