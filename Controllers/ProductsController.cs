using System.Data;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using MvcADO_Demo.Data; // Import the namespace where ProductsRepository is defined 
       

namespace MvcADO_Demo.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductsRepository _productsRepository;
        //Above variable holds the reference to the ProductsRepository instance
        public ProductsController(ProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }
        // Action methods go here
        public IActionResult Index()
        {
            var productsDataSet = _productsRepository.GetProducts();
            //invoking getProducts method for retrieving all products from the database
            return View(productsDataSet);
            // The view will be able to access the DataSet and display the products
            //here we can use viewdata as well as viewbag
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
   [HttpPost]
        public IActionResult Create(string name, decimal price)
        {
            //here we can call insertproduct deined inrepository class with a condition that price> = 0 and model is valid
            if (price >= 0 && ModelState.IsValid)
            // Check if price is valid and model state is valid that means if 
            // model is not returning any error 
            {
                var newProductId = _productsRepository.InsertProduct(name, price);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}