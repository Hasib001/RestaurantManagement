using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagement.Models
{
    public class Customer
    {
        public int customerId { get; set; }

        public string customerName { get; set; }

        public string customerCity { get; set; }
    }
}
