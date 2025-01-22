using Microsoft.AspNetCore.Mvc;
using ECommerceCatalog.Models;

namespace ECommerceCatalog.Controllers
{
    public class AdminController : Controller
    {
        private static List<Product> Products = ProductController.Products;

        public IActionResult Index()
        {
            return View(Products);
        }

        public IActionResult Create()
        {
            return View();
            //return View("~/Views/Admin/Create.cshtml");
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            product.Id = Products.Max(p => p.Id) + 1;
            Products.Add(product);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var product = Products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                Products.Remove(product);
            }
            return RedirectToAction("Index");
        }
    }
}
