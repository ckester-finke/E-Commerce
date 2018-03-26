using System;
using System.Collections.Generic;

namespace Ecommerce.Models
{
    public class Customer : BaseEntity
    {
        public int Customerid { get; set; }
        public string Name { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
        public List<Order> Orders { get; set; }
        public Customer()
        {
            Orders = new List<Order>();
        }
    }
}