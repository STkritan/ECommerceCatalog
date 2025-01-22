using System.Diagnostics;
using ECommerceCatalog.Models;
using Microsoft.AspNetCore.Mvc;



namespace ECommerceCatalog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        public IActionResult Index()
        {
            // Sample products
            List<Product> products = new List<Product>
            {
                 new Product { Id = 1, Name = "Laptop", Price = 800, Description = "High-performance laptop", ImageUrl = "/images/laptop11.jpg", Category = "Electronics" },
                 new Product { Id = 2, Name = "Headphones", Price = 50, Description = "Noise-cancelling headphones", ImageUrl = "/images/headphone.jpg", Category = "Accessories" },
                 new Product { Id = 3, Name = "Shoes", Price = 150, Description = "Comfortable running shoes", ImageUrl = "/images/shoes.jpg", Category = "Clothing" },
                 new Product { Id = 4, Name = "S24", Price = 200, Description = "Samsung S24 5G", ImageUrl = "/images/s24.jpg", Category = "Electronics" },
                 new Product { Id = 5, Name = "Jordan", Price = 100, Description = "Comfortable running shoes", ImageUrl = "/images/jordan.jpg", Category = "Clothing" },
                 new Product { Id = 6, Name = "R15", Price = 6500, Description = "Fastest Bike", ImageUrl = "/images/R15.jpg", Category = "Clothing" },
                 new Product { Id = 7, Name = "KYT TT course", Price = 120, Description = "KYT TT-Course Solid Gloss Black Full Face Motorcycle Helmet", ImageUrl = "/images/kyt.jpg", Category = "Accessories" },
                 new Product { Id = 8, Name = "Casio wr 50", Price = 110, Description = "watch", ImageUrl = "/images/watch.jpg", Category = "Accessories" },
                 new Product { Id = 9, Name = "Laptop", Price = 200, Description = "laptop", ImageUrl = "/images/laptop10.jpg", Category = "Electronics" },
                 new Product { Id = 10, Name = "KYT R2R", Price = 210, Description = "KYT R2R best helmet", ImageUrl = "/images/r2r.jpg", Category = "Accessories" },
                 new Product { Id = 11, Name = "Gopro Hero 10 Black", Price = 800, Description = "Best Action Camera", ImageUrl = "/images/goproo4.jpg", Category = "Electronics" },
                 new Product { Id = 12, Name = "Iphone 13 pro max", Price = 1200, Description = "Best phone for camera", ImageUrl = "/images/iph.jpg", Category = "Electronics" },

            };

            // Group products by category without using lambda
            Dictionary<string, List<Product>> groupedProducts = new Dictionary<string, List<Product>>();

            foreach (var product in products)
            {
                if (!groupedProducts.ContainsKey(product.Category))
                {
                    groupedProducts[product.Category] = new List<Product>();
                }
                groupedProducts[product.Category].Add(product);
            }

            return View(groupedProducts);
        } 
    }
}

