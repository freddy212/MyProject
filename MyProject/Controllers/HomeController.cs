using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyProject.Models;
using Microsoft.AspNetCore.Http;
using MyProject.Products;
using Newtonsoft.Json;

namespace MyProject.Controllers
{
    public class HomeController : Controller
    {
        private MyContext mycontext; 

        public HomeController(MyContext context)
        {
            mycontext = context;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        [HttpPost]
        public IActionResult RegisterOrder(ProductViewModel productvm)
        {
            // Clear the list of products, incase the user redirects to Home. 
            ListOfProducts.clear();
            // Check that atleast one product is ordered.
            bool oneProductOrdered = oneProductIsAtleastOrdered(productvm);
            if (ModelState.IsValid && oneProductOrdered)
            {
                ICollection<Product> myproducts = new List<Product>();
                Product bread = new Bread(productvm.AmountOfBread);
                Product juice = new Juice(productvm.AmountOfJuice);
                ListOfProducts.addProduct(bread); ListOfProducts.addProduct(juice);
                return RedirectToAction("handleReceipt","Receipt");
            }
            return RedirectToAction("orderError", "Error");
        }

        public bool oneProductIsAtleastOrdered(ProductViewModel productvm)
        {
            if(productvm.AmountOfBread == 0 && productvm.AmountOfJuice == 0)
            {
                return false;
            }
            return true;
        }
    }
}
