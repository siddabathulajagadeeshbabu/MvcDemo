using Microsoft.AspNetCore.Mvc;
using MvcDemo.Models; //assuming Models namespace contains Product model

namespace MvcDemo.Controllers
{
    public class ProductsController : Controller
    { //controllers are responsible for handling user requests and returning responses

        //get: /Products/ Index
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { id = 1, Name = "Laptop", Price = 10.00m },
                new Product { id = 2, Name = "Mouse", Price = 20.00m },
                new Product { id = 3, Name = "Printer", Price = 30.00m }
            };
            return View(products); //passing products to the view
        }
    }
}