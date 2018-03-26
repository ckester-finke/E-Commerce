using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Ecommerce.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Controllers
{
    public class OrderController : Controller
    {
        private StoreContext _context;
    
        public OrderController(StoreContext context)
        {
            _context = context;
        }
        [HttpPost]
        [Route("NewCust")]
        public IActionResult NewCust(RegisterCustomerModel model)
        {
            Customer Check = _context.Customers.Where(c => c.Name == model.Name).SingleOrDefault();
            if(ModelState.IsValid){
                if(Check == null){
                Customer NewCust = new Customer();
                NewCust.Name = model.Name;
                NewCust.Created_at = DateTime.Now;
                NewCust.Updated_at = DateTime.Now;
                _context.Customers.Add(NewCust);
                _context.SaveChanges();
                return Redirect("Customers");
            }else{
                TempData["Error"] = "Name already in system";
                    return Redirect("Customers");
                }
            }
            return Redirect("Customers");
        }
    }
}