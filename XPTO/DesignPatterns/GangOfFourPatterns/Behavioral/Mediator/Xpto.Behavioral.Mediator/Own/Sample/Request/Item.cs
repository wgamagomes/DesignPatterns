using System;

namespace Xpto.Behavioral.Mediator.Own.Sample.Request
{
    public class Item
    {
        public Guid Id { get; set; }
        public Guid IdProduct { get; private set; }
        public int Quantity { get; private set; }

        public Item(Guid idProduct, int Quantity)
        {
            Id = Guid.NewGuid();
            IdProduct = idProduct;
            this.Quantity = Quantity;
        }
    }
}
