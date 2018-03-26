using System;
using System.Collections.Generic;

namespace Ecommerce.Models
{
    public class Order : BaseEntity
    {
        public int Orderid { get; set; }
        public int Customerid { get; set; }
        public int Productid { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
    }
}