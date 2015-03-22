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

        public SoldProduct GetSoldProduct(int soldProductId)
        {
            return _db.SoldProduct.FirstOrDefault(p => p.SoldProductId == soldProductId);
        }

        public void EditSoldProduct(SoldProduct soldProduct)
        {
            var soldProductToEdit = GetSoldProduct(soldProduct.SoldProductId);
            soldProductToEdit.ProductId = soldProduct.ProductId;
            soldProductToEdit.CompanyId = soldProduct.CompanyId;
            soldProductToEdit.Location = soldProduct.Location;
            soldProductToEdit.SoldDate = soldProduct.SoldDate;
            soldProductToEdit.StopMaintenance = soldProduct.StopMaintenance;
            _db.SaveChanges();
        }

        public void Delete(int soldProductId)
        {
            var soldProductToDelete = GetSoldProduct(soldProductId);
            _db.SoldProduct.Remove(soldProductToDelete);
            _db.SaveChanges();
        }
    }
}
