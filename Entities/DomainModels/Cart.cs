using System.Collections.Generic;
using Core.Entities;

namespace Entities.DomainModels
{
    public class Cart : IDomainModel
    {
        public Cart()
        {
            CartLines = new List<CartLine>();
        }

        public List<CartLine> CartLines { get; set; }

        //public decimal Total
        //{
        //    get { return CartLines.Sum(c => c.Quantity * c.Product.UnitPrice); }
        //}
    }
}