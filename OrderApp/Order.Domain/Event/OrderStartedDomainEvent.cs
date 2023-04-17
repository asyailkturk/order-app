using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Event
{
    public class OrderStartedDomainEvent : INotification
    {
        public AggregateModels.OrderModels.Order Order { get; set; }

        public string  CustomerUserName { get; set; }

        public OrderStartedDomainEvent(AggregateModels.OrderModels.Order order, string customerUserName)
        {
            Order = order ?? throw new ArgumentNullException(nameof(order));
            CustomerUserName = customerUserName;
        }
    }
}
