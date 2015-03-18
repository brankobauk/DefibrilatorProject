using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DefibrilatorProject.BusinessLogic.Companies;
using DefibrilatorProject.BusinessLogic.DropDowns;
using DefibrilatorProject.BusinessLogic.Maintenances;
using DefibrilatorProject.BusinessLogic.Products;
using DefibrilatorProject.DataLayer.Repositories;
using DefibrilatorProject.Helpers.DropDownHelpers;
using DefibrilatorProject.Helpers.GeneralHelpers;
using DefibrilatorProject.Models.Models;
using DefibrilatorProject.Models.ViewModels;

namespace DefibrilatorProject.BusinessLogic.SoldProducts
{
    public class SoldProductManager
    {
        private readonly SoldProductRepository _soldProductRepository = new SoldProductRepository();
        public List<SoldProduct> GetSoldProducts()
        {
            return _soldProductRepository.GetSoldProducts();
        }

        public void AddSoldProduct(SoldProduct soldProduct)
        {
            _soldProductRepository.AddSoldProduct(soldProduct);
        }

        public SoldProduct GetSoldProduct(int soldProductId)
        {
            return _soldProductRepository.GetSoldProduct(soldProductId);
        }

        public void EditSoldProduct(SoldProduct soldProduct)
        {
            _soldProductRepository.EditSoldProduct(soldProduct);
        }

        public void Delete(int soldProductId)
        {
            _soldProductRepository.Delete(soldProductId);
        }
    }
}
