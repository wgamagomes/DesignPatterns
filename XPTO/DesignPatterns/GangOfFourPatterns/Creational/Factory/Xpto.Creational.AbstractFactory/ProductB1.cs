namespace Xpto.Creational.AbstractFactory
{
    public class ProductB1 : ProductBBase
    {
        public override string Interact(ProductABase product)
        {
            return $"{GetType().Name} interacts with {product.GetType().Name}";            
        }
    }
}
