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
    public class HomeController : Controller
    {
        private StoreContext _context;
    
        public HomeController(StoreContext context)
        {
            _context = context;
        }
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Dash()
        {
            return View();
        }
        [HttpGet]
        [Route("Customers")]
        public IActionResult Customer()
        {
            List<Customer> C = _context.Customers.Where(s => s.Name != null).ToList();
            ViewBag.Custs = C;
            return View();
        }
        [HttpGet]
        [Route("Orders")]
        public IActionResult Order()
        {
            return View();
        }
        [HttpGet]
        [Route("Products")]
        public IActionResult Product()
        {
            List<Product> L = _context.Products.Where(d => d.Name != null).ToList();
            ViewBag.Prods = L;
            return View();
        }
    }
}
