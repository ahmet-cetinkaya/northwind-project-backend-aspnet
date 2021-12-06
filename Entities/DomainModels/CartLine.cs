using Core.Entities;
using Entities.Concrete;

namespace Entities.DomainModels
{
    public class CartLine : IDomainModel
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}