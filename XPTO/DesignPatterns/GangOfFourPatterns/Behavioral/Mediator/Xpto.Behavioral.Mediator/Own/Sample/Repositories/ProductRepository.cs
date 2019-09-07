using System;
using System.Collections.Generic;
using System.Linq;

namespace Xpto.Behavioral.Mediator.Own.Sample.Repositories
{
    public class ProductRepository
    {
        public static List<Product> Products;

        public ProductRepository()
        {
            Products = new List<Product>();
        }

        void Insert(Product product)
        {
            Products.Add(product); 
        }

        List<Product> Get(Func<Product,bool> predicate)
        {
            return Products
                    .Where(predicate)
                    .ToList();
        }
    }
}
