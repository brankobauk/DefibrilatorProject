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
            var productToGet = _productRepository.GetProduct(productId);
            var product = new Product()
            {
                Name = productToGet.Name,
                Model = productToGet.Model,
                ProductProperty = _productRepository.GetProductPropertyByProductId(productId)
            };
            return product;
        }

        private List<ProductProperty> GetProductPropertiesFromForm(int productId, FormCollection collection)
        {
            var productProperties = new List<ProductProperty>();
            var counter = Convert.ToInt32(collection["ProductPropertyCount"]);
            for (var i = 1; i <= counter; i++)
            {
                var productPropertyNameTag = "ProductProperty_Name_" + i;
                var productPropertyServiceRateTag = "ProductProperty_ServiceRate_" + i;
                var productPropertyName = Convert.ToString(collection[productPropertyNameTag]);
                var productPropertyServiceRate = Convert.ToInt32(collection[productPropertyServiceRateTag]);
                if(!string.IsNullOrEmpty(productPropertyName))
                {
                    var productProperty = new ProductProperty()
                    {
                        Name = productPropertyName,
                        ServiceRate = productPropertyServiceRate,
                        ProductId = productId
                    };
                    productProperties.Add(productProperty);
                }
                
            }
            return productProperties;
        }

        public List<ProductProperty> GetProductPropertyByProductId(int productId)
        {
            return _productRepository.GetProductPropertyByProductId(productId);
        }

    }
}
