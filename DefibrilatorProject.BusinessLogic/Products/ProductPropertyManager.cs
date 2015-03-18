using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DefibrilatorProject.DataLayer.Repositories;
using DefibrilatorProject.Models.Models;

namespace DefibrilatorProject.BusinessLogic.Products
{
    
    public class ProductPropertyManager
    {
        private readonly ProductPropertyRepository _productPropertyRepository = new ProductPropertyRepository();
        public List<ProductProperty> GetProductPropertyByProductId(int productId)
        {
            return _productPropertyRepository.GetProductPropertyByProductId(productId);
        }
    }
}
