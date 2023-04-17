using MediatR;
using Order.Domain.Event;
using Order.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.AggregateModels.OrderModels
{
    public class Order : BaseEntity, IAggregateRoot
    {
       
        public DateTime OrderDate { get; private set; }
        public string Description { get; private set; }
        public string Username{ get; private set; }
        public string  OrderStatus { get; private set; }
        public Adress  Adress { get; private set; }
        public ICollection<OrderItem> OrderItems { get;  set; }

        public Order(DateTime orderDate, string description, string userName, string orderStatus, Adress adress, ICollection<OrderItem> orderItems)
        {
            if (orderDate < DateTime.Now)
                throw new Exception("Order date must be greater than now");

            if (adress.City == "")
                throw new Exception("city cannot be empty");

            OrderDate = orderDate;
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Username = userName;
            OrderStatus = orderStatus ?? throw new ArgumentNullException(nameof(orderStatus));
            Adress = adress ?? throw new ArgumentNullException(nameof(adress));
            OrderItems = orderItems ?? throw new ArgumentNullException(nameof(orderItems));
            AddDomainEvent(new OrderStartedDomainEvent(this, userName));
        }

        public void AddOrderItems(int quantity,  int productId, decimal price)
        {
            OrderItem item = new(quantity, productId, price);
            OrderItems.Add(item);
        }
    }
}
