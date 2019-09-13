using System;

namespace Xpto.Behavioral.Mediator.Own.Sample
{
    public class Product
    {
        public double Price { get; set; }

        public string Description { get; private set; }

        public Guid Id { get; set; }

        public int Quantity { get; private set; }

        public Product(string description, int quantity, double price)
        {
            Id = Guid.NewGuid();
            Description = description;
            Quantity = quantity;
            Price = price;
        }

        public void AlterPrice(double price)
        {
            Price = price;
        }

        public void AlterDescription(string description)
        {
            Description = description;
        }

        public int IncreaseQuantity(int increment)
        {
            return Quantity += increment;
        }

        internal static bool Available(Product product)
        {
            return product.Quantity > 0;
        }

        internal static bool IsValid(Product product)
        {
            return product != null;
        }

        public int DecreaseQuantity(int decrement)
        {
            if (Quantity - decrement < 0)
            {
                throw new ArgumentException("Decrease quantity error");
            }

            return Quantity -= decrement;
        }
    }
}
