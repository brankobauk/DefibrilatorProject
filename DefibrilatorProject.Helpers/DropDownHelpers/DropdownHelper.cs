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
    public class DropDownHelper
    {
        public IEnumerable<SelectListItem> GetCompanyListForDropDown(List<Company> companies)
        {
            return companies.Select(company => new SelectListItem { Value = company.CompanyId.ToString(CultureInfo.InvariantCulture), Text = company.Name.ToString(CultureInfo.InvariantCulture) }).ToList();
        }

        public IEnumerable<SelectListItem> GetProductListForDropDown(List<Product> products)
        {
            return products.Select(product => new SelectListItem { Value = product.ProductId.ToString(CultureInfo.InvariantCulture), Text = product.Name.ToString(CultureInfo.InvariantCulture) }).ToList();
        }

        public IEnumerable<SelectListItem> GetSoldProductListForDropDown(List<SoldProduct> soldProducts)
        {
            return soldProducts.Select(soldProduct => new SelectListItem { Value = soldProduct.SoldProductId.ToString(CultureInfo.InvariantCulture), Text = soldProduct.Company.Name + " - " + soldProduct.Product.Name }).ToList();
        }

        public IEnumerable<SelectListItem> GetProductPropertyForDropDown(List<ProductProperty> productProperties)
        {
            return productProperties.Select(productProperty => new SelectListItem { Value = productProperty.ProductPropertyId.ToString(CultureInfo.InvariantCulture), Text = productProperty.Name.ToString(CultureInfo.InvariantCulture) }).ToList();
        }

        public IEnumerable<SelectListItem> GetCompanyListForDropDownWithEmptyItem(List<Company> companies)
        {
            var items = new List<SelectListItem>();
            var firstItem = new SelectListItem
            {
                Value = "",
                Text = "--- Choose Company ---"
            };
            items.Add(firstItem);
            items.AddRange(GetCompanyListForDropDown(companies));
            return items;
        }

        public IEnumerable<SelectListItem> GetProductListForDropDownWithEmptyItem(List<Product> products)
        {
            var items = new List<SelectListItem>();
            var firstItem = new SelectListItem
            {
                Value = "",
                Text = "--- Choose Product ---"
            };
            items.Add(firstItem);
            items.AddRange(GetProductListForDropDown(products));
            return items;
        }

        public IEnumerable<SelectListItem> GetSoldProductListForDropDownWithEmptyItem(List<SoldProduct> soldProduct)
        {
            var items = new List<SelectListItem>();
            var firstItem = new SelectListItem
            {
                Value = "",
                Text = "--- Choose SoldProduct ---"
            };
            items.Add(firstItem);
            items.AddRange(GetSoldProductListForDropDown(soldProduct));
            return items;
        }

        public IEnumerable<SelectListItem> GetProductPropertyForDropDownWithEmptyItem(List<ProductProperty> productProperties)
        {
            var items = new List<SelectListItem>();
            var firstItem = new SelectListItem
            {
                Value = "",
                Text = "--- Choose SoldProduct ---"
            };
            items.Add(firstItem);
            items.AddRange(GetProductPropertyForDropDown(productProperties));
            return items;
        }
    }
}
