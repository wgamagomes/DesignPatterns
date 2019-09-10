using System;
using Xpto.Behavioral.Mediator.Own.Interfaces;

namespace Xpto.Behavioral.Mediator.Own.Sample.Request
{
    public class ProductBuyerRequest : IRequest
    {
        public Guid ProductId { get; private set; }

        public int Quantity { get; private set; }
        public ProductBuyerRequest(Guid productId, int quantity)
        {
            ProductId = productId;
            Quantity = quantity;
        }
    }
}
