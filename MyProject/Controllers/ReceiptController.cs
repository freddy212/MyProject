using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyProject.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace MyProject.Controllers
{
    public class ReceiptController : Controller
    {
        MyContext context;

        public ReceiptController(MyContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult HandleReceipt()
        {
            if(ListOfProducts.getListOfProducts().Count == 0)
            {
                return RedirectToAction("noProductsSelected", "Error");
            }
            ReceiptViewModel rvm = new ReceiptViewModel();
            rvm.products = ListOfProducts.getListOfProducts();
            return View(rvm);
        }

            public IActionResult CreateReceipt()
        {
            return View();
        }
        [HttpPost]
        // Using bind to prevent overposting.
        public IActionResult CreateReceipt([Bind("name","address","city")] ReceiptViewModel receiptvm)
        {
            if (ModelState.IsValid)
            {
                Receipt finalreceipt = new Receipt();
                finalreceipt.city = receiptvm.city; finalreceipt.address = receiptvm.address; finalreceipt.name = receiptvm.name;
                finalreceipt.products = Utitlities.getProductsInHtml();
                finalreceipt.totalPrice = Utitlities.getTotalPrice();
                context.Receipts.Add(finalreceipt);
                context.SaveChanges();
                ListOfProducts.clear();
                return View(finalreceipt);
            }
            return RedirectToAction("errorCreatingReceipt", "Error");
        }
        [HttpGet]
        public IActionResult GetAllReceipts()
        {
            ICollection<Receipt> myreceipts = (ICollection<Receipt>) context.Receipts.ToList();
            if(myreceipts.Count != 0)
            {
                return View(myreceipts);
            }
            return RedirectToAction("noReceiptsInDatabase", "Error");
        }
        public IActionResult EditReceipt()
        {
            return View("UnsupportedOperation", "Error");
        }
        [HttpGet]
        public IActionResult GetProfit()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ShowProfit(int id)
        {
            Receipt foundreceipt = context.Receipts.SingleOrDefault(i => i.id == id);
            if(foundreceipt != null)
            {
                return View(foundreceipt.totalPrice / 10);
            }
            return RedirectToAction("noReceiptsInDatabase", "Error");
        }
    }
}