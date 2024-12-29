using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using E_commerce_Application_1.data;
using E_commerce_Application_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_commerce_Application_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDBcontext _dbContext;
   

        public HomeController(AppDBcontext dbContext)
        {
            this._dbContext = dbContext;



        }

        public IActionResult Index()
        {
            // Fetch the list of products from the database
            var list = _dbContext.classes.ToList();

            // Pass the list directly to the view as the model (preferred approach)
            return View(list);


        
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        // Add Product
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind ("Name", "Price", "Description", "StockQuantity")] Class product)
        {
          
                _dbContext.classes.Add(product);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            
        }

        // Edit Product
        
        public IActionResult Edit(int id)
        {

            var product = _dbContext.classes.FirstOrDefault(u => u.id == id);


            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Class product)
        {
            
                _dbContext.classes.Update(product);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            
        }

        // Delete Product
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var product = _dbContext.classes.FirstOrDefault(p => p.id == id);

            if (product == null)
            {
                // Handle the case where the product is not found
                return View("Error"); // Show an error view if the product is not found
            }

            _dbContext.classes.Remove(product);
            _dbContext.SaveChanges();

            return RedirectToAction("Index"); // Redirect to the Index page after deletion
        }

    }

}

