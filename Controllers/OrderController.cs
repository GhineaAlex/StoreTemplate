using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HeadphonesStore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HeadphonesStore.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderRepo _orderRepo;
        private readonly ShoppingCart _shoppingCart;

        public OrderController(IOrderRepo orderRepo, ShoppingCart shoppingCart)
        {
            _orderRepo = orderRepo;
            _shoppingCart = shoppingCart;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            if(_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Empty cart, add headphones");
            }

            if(ModelState.IsValid)
            {
                _orderRepo.CreateOrder(order);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }
            return View(order);

        }
        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Ty for your order";
            return View();
        }
    }
}