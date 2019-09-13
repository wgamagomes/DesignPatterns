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
            if (Products == null)
                Products = new List<Product>();
        }

        public void Insert(Product product)
        {
            Products.Add(product);
        }

        public List<Product> Get(Func<Product, bool> predicate)
        {
            return Products
                    .Where(predicate)
                    .ToList();
        }

        public void Delete(Func<Product, bool> predicate)
        {
            var result = Products
                    .Where(predicate)
                    .ToList();

            foreach (var prod in result)
            {
                Products.Remove(prod);
            }
        }

        public void Update(Product product)
        {
            var foundProduct = Products
                    .Where(p => p.Id == product.Id)
                    .First();

            foundProduct.Price = product.Price;
            foundProduct.AlterDescription(product.Description);
        }
    }
}
