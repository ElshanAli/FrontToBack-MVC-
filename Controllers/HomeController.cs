using FrontToBack.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Products> products = new List<Products>();
            products.Add(new Products { Id = 1, Name = "Orange", ImageUrl = "oranges-1995056_640.jpg", Price = 20, Raitng = 5 });
            products.Add(new Products { Id = 2, Name = "Grape", ImageUrl = "wines-1761613_640.jpg", Price = 30, Raitng = 3 });
            products.Add(new Products { Id = 3, Name = "Banana", ImageUrl = "banana-2181470_640.jpg", Price = 40, Raitng = 5 });
            products.Add(new Products { Id = 4, Name = "Kiwi", ImageUrl = "kiwi-coctail-1447939_640.jpg", Price = 50, Raitng = 5 });
            products.Add(new Products { Id = 5, Name = "Strawberries", ImageUrl = "strawberries-3359755_640.jpg", Price = 60, Raitng = 5 });
            products.Add(new Products { Id = 6, Name = "Cherries", ImageUrl = "cherries-3522365_640.jpg", Price = 70, Raitng = 5 });
            return View(products);
        }

        public IActionResult Detail()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult ProductListing()
        {
            return View();
        }

        public IActionResult Blogs()
        {
            List<Products> products = new List<Products>();
            products.Add(new Products { Id = 1, Name = "Orange", ImageUrl = "oranges-1995056_640.jpg", Price = 20, Raitng = 5 });
            products.Add(new Products { Id = 2, Name = "Grape", ImageUrl = "wines-1761613_640.jpg", Price = 30, Raitng = 3 });
            products.Add(new Products { Id = 4, Name = "Kiwi", ImageUrl = "kiwi-coctail-1447939_640.jpg", Price = 50, Raitng = 5 });
            products.Add(new Products { Id = 5, Name = "Strawberries", ImageUrl = "strawberries-3359755_640.jpg", Price = 60, Raitng = 5 });
           
            return View(products);
        }
      
    }
}
