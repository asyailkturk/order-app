using MediatR;
using Order.Application.Repository;
using Order.Domain.AggregateModels.CustomerModels;
using Order.Domain.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Application.DomainEventHandlers
{
    public class OrderStartedDomainEventHandler : INotificationHandler<OrderStartedDomainEvent>
    {
        private readonly ICustomerRepository customerRepository;

        public OrderStartedDomainEventHandler(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public Task Handle (OrderStartedDomainEvent notification, CancellationToken cancellationToken)
        {
            if(notification.Order.Username == "")
            {
               //customerRepository.Add(new Customer(notification.CustomerUserName));
            }
            return Task.CompletedTask;
        }
    }
}
