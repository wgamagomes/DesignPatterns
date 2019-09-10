using System;
using System.Linq;
using Xpto.Behavioral.Mediator.Own.Interfaces;
using Xpto.Behavioral.Mediator.Own.Sample.Repositories;

namespace Xpto.Behavioral.Mediator.Own.Sample.Request
{
    public class ProductBuyerHandler : IRequestHandler<ProductBuyerRequest>
    {
        private ProductRepository _productRepository;
        private OrderRepository _orderRepository;

        private void Commit()
        {

        }

        public ProductBuyerHandler()
        {
            _productRepository = new ProductRepository();
            _orderRepository = new OrderRepository();
        }
        public void Handle(ProductBuyerRequest request)
        {
            var product = _productRepository
                    .Get(p => p.Id == request.ProductId)
                    .FirstOrDefault();

            if (!(Product.IsValid(product) && Product.Available(product)))
            {
                throw new ArgumentException("Product Not Found  Or Unavailable");
             }


            product.DecreaseQuantity(request.Quantity);
            _productRepository.Update(product);

            var order = new Order();
            var item = new Item(request.ProductId, request.Quantity);

            order.AddItem(item);

            _orderRepository.Insert(order);

            Commit();
        }
    }
}
