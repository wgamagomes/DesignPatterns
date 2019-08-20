namespace Xpto.Creational.AbstractFactory
{
    public class Factory1 : IFactory
    {
        public ProductABase CreateProductA()
        {
            return new ProductA1();
        }
        public ProductBBase CreateProductB()
        {
            return new ProductB1();
        }
    }
}
