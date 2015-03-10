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

        public void EditProduct(int id, Product product)
        {
            var productToEdit = _db.Product.FirstOrDefault(p => p.ProductId == id);
            if (productToEdit == null) return;
            productToEdit.Name = product.Name;
            _db.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            var productToDelete = _db.Product.FirstOrDefault(p => p.ProductId == id);
            _db.Product.Remove(productToDelete);
            _db.SaveChanges();
        }

        public Product GetProduct(int id)
        {
            return _db.Product.FirstOrDefault(p => p.ProductId == id);
        }

        public void AddProductProperty(ProductProperty productProperty)
        {
            _db.ProductProperty.Add(productProperty);
            _db.SaveChanges();
        }
    }
}
