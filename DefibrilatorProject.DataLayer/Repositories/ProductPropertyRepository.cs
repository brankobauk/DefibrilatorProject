using System.Collections.Generic;
using System.Linq;
using DefibrilatorProject.DataLayer.Context;
using DefibrilatorProject.Models.Models;

namespace DefibrilatorProject.DataLayer.Repositories
{
    public class ProductPropertyRepository
    {
        private readonly DefibrilatorProjectContext _db = new DefibrilatorProjectContext();
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
