using System;
using System.Collections.Generic;
using System.Text;

namespace Xpto.Creational.AbstractFactory
{
    public class Client
    {
        private readonly ProductABase _productA;
        private readonly ProductBBase _productB;

        public Client(IFactory factory)
        {
            _productA = factory.CreateProductA();
            _productB = factory.CreateProductB();
        }

        public string Run()
        {
            return _productB.Interact(_productA);
        }
    }
}
