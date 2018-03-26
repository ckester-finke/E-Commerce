using System;
using System.Collections.Generic;

namespace Ecommerce.Models
{
    public class Product : BaseEntity
    {
        public int Productid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
        public List<Order> Orders { get; set; }
        public Product()
        {
            Orders = new List<Order>();
        }
    }
}