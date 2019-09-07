using System;
using System.Collections.Generic;
using System.Text;

namespace Xpto.Behavioral.Mediator.Own.Sample
{
    public class Product
    {
        public decimal Price { get; set; }

        public Guid Id { get; set; }

        public Product()
        {
            Id = Guid.NewGuid();
        }
    }
}
