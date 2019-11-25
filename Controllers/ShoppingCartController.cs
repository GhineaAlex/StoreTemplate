using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HeadphonesStore.Models;
using HeadphonesStore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HeadphonesStore.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IHeadphonesRepo _headphonesRepo;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IHeadphonesRepo headphonesRepo, ShoppingCart shoppingCart)
        {
            _headphonesRepo = headphonesRepo;
            _shoppingCart = shoppingCart;
        }
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int headphonesId)
        {
            var selectedHeadphones = _headphonesRepo.GetAll().FirstOrDefault(p => p.HeadphonesId == headphonesId);

            if (selectedHeadphones != null)
            {
                _shoppingCart.AddToCart(selectedHeadphones, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int headphonesId)
        {
            var selectedHeadphones = _headphonesRepo.GetAll().FirstOrDefault(p => p.HeadphonesId == headphonesId);

            if(selectedHeadphones != null)
            {
                _shoppingCart.RemoveFromCart(selectedHeadphones);
            }
            return RedirectToAction("Index");
        }
    }
}