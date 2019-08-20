namespace Xpto.Creational.AbstractFactory
{
    public interface IFactory
    {
          ProductABase CreateProductA();
          ProductBBase CreateProductB();
    }
}
