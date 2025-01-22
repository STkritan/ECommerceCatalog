using Microsoft.AspNetCore.Mvc;
using ECommerceCatalog.Models;

namespace ECommerceCatalog.Controllers
{
    public class CartController : Controller
    {
        private static List<CartItem> Cart = new List<CartItem>();

        public IActionResult Index()
        {
            return View(Cart);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AddToCart(int id, string name, decimal price, int Quantity, string ImageUrl)
        {
            var cartItem = Cart.FirstOrDefault(c => c.ProductId == id);
            if (cartItem == null)
            {
                Cart.Add(new CartItem { ProductId = id, ProductName = name, Price = price, Quantity = Quantity, ImageUrl =ImageUrl });
            }
            else
            {
                cartItem.Quantity++;
            }

            return RedirectToAction("Index");
        }
        public IActionResult UpdateQuantity(int id, int quantity)
        {
            var cartItem = Cart.FirstOrDefault(c => c.ProductId == id);
            if (cartItem != null && quantity > 0)
            {
                cartItem.Quantity = quantity;
            }
            return RedirectToAction("Index");
        }

        public IActionResult RemoveFromCart(int id)
        {
            var cartItem = Cart.FirstOrDefault(c => c.ProductId == id);
            if (cartItem != null)
            {
                Cart.Remove(cartItem);
            }
            return RedirectToAction("Index");
        }
    }
}
