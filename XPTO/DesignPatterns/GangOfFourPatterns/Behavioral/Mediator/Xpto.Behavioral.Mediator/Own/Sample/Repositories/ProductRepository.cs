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

        public void Update(Guid id, decimal price, string description)
        {
            var foundProduct = Products
                    .Where(p=>p.Id == id)
                    .First();

            foundProduct.Price = price;
            foundProduct.Description = description;

        }


    }
}
