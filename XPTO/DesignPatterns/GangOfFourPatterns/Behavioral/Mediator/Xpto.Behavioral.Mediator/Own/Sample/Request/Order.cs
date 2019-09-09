using System;
using System.Collections.Generic;

namespace Xpto.Behavioral.Mediator.Own.Sample.Request
{
    public class Order
    {
        public Guid Id { get; set; }

        public List<Item> Items { get; private set; }

        public Order()
        {
            Id = Guid.NewGuid();
            Items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }
    }
}
