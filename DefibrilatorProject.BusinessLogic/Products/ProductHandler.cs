using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using DefibrilatorProject.BusinessLogic.DropDowns;
using DefibrilatorProject.BusinessLogic.SoldProducts;
using DefibrilatorProject.DataLayer.Repositories;
using DefibrilatorProject.Models.Models;
using DefibrilatorProject.Models.ViewModels;

namespace DefibrilatorProject.BusinessLogic.Products
{
    public class ProductHandler
    {
        private readonly ProductManager _productManager = new ProductManager();
        private readonly SoldProductManager _soldProductManager = new SoldProductManager();
        private readonly DropDownManager _dropDownManager = new DropDownManager();
        public List<Product> GetProducts()
        {
            return _productManager.GetProducts();
        }

        public void AddProduct(Product product)
        {
            _productManager.AddProduct(product);
        }


        public void EditProduct(Product product)
        {
            _productManager.EditProduct(product);
        }

        public void DeleteProduct(int productId)
        {
            _productManager.DeleteProduct(productId);
        }

        public Product GetProduct(int productId)
        {
            var productToGet = _productManager.GetProduct(productId);
            var product = new Product()
            {
                Name = productToGet.Name,
                Model = productToGet.Model,
                ProductProperty = _productManager.GetProductPropertyByProductId(productId)
            };
            return product;
        }

        public MaintenanceViewModel GetProductPropertyForDropDownWithEmptyItem(int soldProductId)
        {
            var productId = _soldProductManager.GetSoldProduct(soldProductId).ProductId;
            return new MaintenanceViewModel()
            {
                ProductProperties = _dropDownManager.GetProductPropertyForDropDownWithEmptyItem(_productManager.GetProductPropertyByProductId(productId))
            };
        }
    }
}
