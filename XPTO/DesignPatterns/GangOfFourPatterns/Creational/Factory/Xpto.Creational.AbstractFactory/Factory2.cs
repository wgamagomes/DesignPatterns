namespace Xpto.Creational.AbstractFactory
{
    public class Factory2 : IFactory
    {
        public ProductABase CreateProductA()
        {
            return new ProductA2();
        }
        public ProductBBase CreateProductB()
        {
            return new ProductB2();
        }
    }
}
