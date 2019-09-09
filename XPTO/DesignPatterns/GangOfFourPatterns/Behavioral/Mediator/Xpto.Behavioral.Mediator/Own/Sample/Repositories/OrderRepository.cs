using System;
using System.Collections.Generic;
using System.Linq;
using Xpto.Behavioral.Mediator.Own.Sample.Request;

namespace Xpto.Behavioral.Mediator.Own.Sample.Repositories
{
    class OrderRepository
    {
        public static List<Order> Orders;

        public OrderRepository()
        {
            Orders = new List<Order>();
        }

        public void Insert(Order Order)
        {
            Orders.Add(Order);
        }

        public List<Order> Get(Func<Order, bool> predicate)
        {
            return Orders
                    .Where(predicate)
                    .ToList();
        }

        public void Delete(Func<Order, bool> predicate)
        {
            var result = Orders
                    .Where(predicate)
                    .ToList();

            foreach (var prod in result)
            {
                Orders.Remove(prod);
            }
        }
    }
}
