using System.Collections.Generic;
using System.Linq;
using DefibrilatorProject.DataLayer.Context;
using DefibrilatorProject.Models.Models;

namespace DefibrilatorProject.DataLayer.Repositories
{
    public class ProductRepository
    {
        private readonly DefibrilatorProjectContext _db = new DefibrilatorProjectContext();

        public List<Product> GetProducts()
        {
            return _db.Product.ToList();
        }

        public void AddProduct(Product product)
        {
            _db.Product.Add(product);
            _db.SaveChanges();
        }

        public void EditProduct(Product product)
        {
            var productToEdit = _db.Product.FirstOrDefault(p => p.ProductId == product.ProductId);
            if (productToEdit == null) return;
            productToEdit.Name = product.Name;
            productToEdit.Model = product.Model;
            _db.SaveChanges();

            foreach (var productProperty in product.ProductProperty)
            {
                var productPropertyToEdit = GetProductProperty(productProperty.ProductPropertyId);
                productPropertyToEdit.Name = productProperty.Name;
                productPropertyToEdit.ServiceRate = productProperty.ServiceRate;
                _db.SaveChanges();
            }
            
        }

        public void DeleteProduct(int id)
        {
            var productToDelete = _db.Product.FirstOrDefault(p => p.ProductId == id);
            _db.Product.Remove(productToDelete);
            _db.SaveChanges();
        }

        public Product GetProduct(int productId)
        {
            return _db.Product.FirstOrDefault(p => p.ProductId == productId);
        }

        public void AddProductProperty(ProductProperty productProperty)
        {
            _db.ProductProperty.Add(productProperty);
            _db.SaveChanges();
        }

        public List<ProductProperty> GetProductPropertyByProductId(int productId)
        {
            return _db.ProductProperty.Where(p => p.ProductId == productId).ToList();
        }

        public ProductProperty GetProductProperty(int productPropertyId)
        {
            return _db.ProductProperty.FirstOrDefault(p => p.ProductPropertyId == productPropertyId);
        }
    }
}
