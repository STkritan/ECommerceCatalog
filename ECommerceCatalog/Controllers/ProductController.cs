using Microsoft.AspNetCore.Mvc;
using ECommerceCatalog.Models;
using System.ComponentModel.DataAnnotations;

namespace ECommerceCatalog.Controllers
{
    public class ProductController : Controller
    {
        public static List<Product> Products = new List<Product>
    {
        new Product { Id = 1, Name = "Laptop", Price = 800, Description = "High-performance laptop", ImageUrl = "/images/laptop11.jpg", Category = "Electronics" },
        new Product { Id = 2, Name = "Headphones", Price = 50, Description = "Noise-cancelling headphones", ImageUrl = "/images/headphone.jpg", Category = "Accessories" },
        new Product { Id = 3, Name = "Shoes", Price = 150, Description = "Comfortable running shoes", ImageUrl = "/images/shoes.jpg", Category = "Clothing" },
        new Product { Id = 4, Name = "S24", Price = 200, Description = "Samsung S24 5G", ImageUrl = "/images/s24.jpg", Category = "Elecronics" },
         new Product { Id = 5, Name = "Jordan", Price = 100, Description = "Comfortable running shoes", ImageUrl = "/images/jordan.jpg", Category = "Clothing" },
         new Product { Id = 6, Name = "R15", Price = 6500, Description = "Fastest Bike", ImageUrl = "/images/R15.jpg", Category = "Clothing" },
         new Product { Id = 7, Name = "KYT TT course", Price = 120, Description = "KYT TT-Course Solid Gloss Black Full Face Motorcycle Helmet", ImageUrl = "/images/kyt.jpg", Category = "Clothing" },
         new Product { Id = 8, Name = "Casio wr 50", Price = 110, Description = "watch", ImageUrl = "/images/watch.jpg", Category = "Accessories" },
         new Product { Id = 9, Name = "Laptop", Price = 200, Description = "laptop", ImageUrl = "/images/laptop10.jpg", Category = "Clothing" },
         new Product { Id = 10, Name = "KYT R2R", Price = 210, Description = "KYT R2R best helmet", ImageUrl = "/images/r2r.jpg", Category = "Clothing" },
         new Product { Id = 11, Name = "Gopro Hero 10 Black", Price = 800, Description = "Best Action Camera", ImageUrl = "/images/goproo4.jpg", Category = "Electronics" },
         new Product { Id = 12, Name = "Iphone 13 pro max", Price = 1200, Description = "Best phone for camera", ImageUrl = "/images/iph.jpg", Category = "Electronics" },

    };

        public IActionResult Index(string category)
        {
            var filteredProducts = string.IsNullOrEmpty(category)
                ? Products
                : Products.Where(p => p.Category == category).ToList();

            return View(filteredProducts);
        }

        public IActionResult Details(int id)
        {
            var product = Products.FirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();

            return View(product);
        }

    }
}
