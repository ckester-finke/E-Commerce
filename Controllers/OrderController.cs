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
            List<Customer> C = _context.Customers.Where(s => s.Name != null).ToList();
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
            ViewBag.Custs = C;
            return View("Customer");
        }
        [HttpPost]
        [Route("NewProd")]
        public IActionResult NewProd(RegisterProductModel model)
        {
            List<Product> L = _context.Products.Where(d => d.Name != null).ToList();
            Product Test = _context.Products.Where(p => p.Name == model.Name).SingleOrDefault();
            if(ModelState.IsValid)
            {
                if(Test == null)
                {
                    Product New = new Product();
                    New.Name = model.Name;
                    New.Description = model.Description;
                    New.Quantity = model.Quantity;
                    New.Image = model.Image;
                    New.Created_at = DateTime.Now;
                    New.Updated_at = DateTime.Now;
                    _context.Products.Add(New);
                    _context.SaveChanges();
                    return Redirect("Products");
                }else{
                     TempData["Error"] = "Name already in system";
                    return Redirect("Products");      
                }
            }
            ViewBag.Prods = L;
            return View("Product");
        }
    }
}