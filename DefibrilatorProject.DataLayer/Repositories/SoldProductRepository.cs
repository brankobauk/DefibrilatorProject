using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DefibrilatorProject.DataLayer.Context;
using DefibrilatorProject.Models.Models;

namespace DefibrilatorProject.DataLayer.Repositories
{
    public class SoldProductRepository
    {
        private readonly DefibrilatorProjectContext _db = new DefibrilatorProjectContext();
        public List<SoldProduct> GetSoldProducts()
        {
            return _db.SoldProduct.Where(p => p.CompanyId == p.Company.CompanyId && p.ProductId == p.Product.ProductId).Include(p => p.Company).Include(p => p.Product).ToList();
        }

        public void AddSoldProduct(SoldProduct soldProduct)
        {
            _db.SoldProduct.Add(soldProduct);
            _db.SaveChanges();
        }
    }
}
