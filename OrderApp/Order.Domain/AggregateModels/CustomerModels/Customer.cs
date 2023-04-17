using Order.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.AggregateModels.CustomerModels
{
    public class Customer : BaseEntity
    {
        public string Username { get; private set; }

        public Customer(string userName)
        {
            Username = userName; 
        }
    }
}
