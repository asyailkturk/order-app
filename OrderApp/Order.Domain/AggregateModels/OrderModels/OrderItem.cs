using Order.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.AggregateModels.OrderModels
{
    public class OrderItem: BaseEntity
    {
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int ProductId { get; set; }

        public OrderItem(int quantity, int productId, decimal price)
        {
            Quantity = quantity;
            ProductId = productId;
            Price = price;
        }
    }

}
