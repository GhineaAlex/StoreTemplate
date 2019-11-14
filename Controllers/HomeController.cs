using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HeadphonesStore.Models;
using HeadphonesStore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HeadphonesStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHeadphonesRepo _headphonesRepo;
        public HomeController(IHeadphonesRepo headphonesRepo)
        {
            _headphonesRepo = headphonesRepo;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel { 
            PopularHeadphones = _headphonesRepo.PopularHeadphones
            };
            return View(homeViewModel);
        }
    }
}