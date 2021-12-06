using System.Collections.Generic;
using Entities.Concrete;
using Entities.DomainModels;

namespace Business.Abstract
{
    public interface ICartService
    {
        List<CartLine> List(Cart cart);
        void AddToCart(Cart cart, Product product);
        void RemoveFromCart(Cart cart, int productId);
    }
}