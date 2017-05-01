using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyProject.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult orderError()
        {
            return View();
        }
        public IActionResult ErrorCreatingReceipt()
        {
            return View();
        }
        public IActionResult NoProductsSelected()
        {
            return View();
        }
        public IActionResult NoReceiptsInDatabase()
        {
            return View();
        }
        public IActionResult UnsupportedOperation()
        {
            return View();
        }
    }
}