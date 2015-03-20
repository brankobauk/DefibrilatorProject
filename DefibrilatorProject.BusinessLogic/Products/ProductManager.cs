using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using DefibrilatorProject.DataLayer.Repositories;
using DefibrilatorProject.Models.Models;
using DefibrilatorProject.Models.ViewModels;

namespace DefibrilatorProject.BusinessLogic.Products
{
    public class ProductManager
    {
        private readonly ProductRepository _productRepository = new ProductRepository();
        public List<Product> GetProducts()
        {
            return _productRepository.GetProducts();
        }

        public void AddProduct(Product product)
        {
            _productRepository.AddProduct(product);
        }


        public void EditProduct(Product product)
        {
            _productRepository.EditProduct(product);
        }

        public void DeleteProduct(int productId)
        {
            _productRepository.DeleteProduct(productId);
        }

        public Product GetProduct(int productId)
        {
            return _productRepository.GetProduct(productId);
            
        }

        public List<ProductProperty> GetProductPropertyByProductId(int productId)
        {
            return _productRepository.GetProductPropertyByProductId(productId);
        }

    }
}
