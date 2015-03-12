using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using DefibrilatorProject.Models.Models;

namespace DefibrilatorProject.Helpers.DropDownHelpers
{
    public class DropdownHelper
    {
        public IEnumerable<SelectListItem> GetCompanyListForDropDown(IEnumerable<Company> companies)
        {
            return companies.Select(company => new SelectListItem { Value = company.CompanyId.ToString(CultureInfo.InvariantCulture), Text = company.Name.ToString(CultureInfo.InvariantCulture) }).ToList();
        }

        public IEnumerable<SelectListItem> GetProductListForDropDown(List<Product> products)
        {
            return products.Select(product => new SelectListItem { Value = product.ProductId.ToString(CultureInfo.InvariantCulture), Text = product.Name.ToString(CultureInfo.InvariantCulture) }).ToList();
        }
    }
}
