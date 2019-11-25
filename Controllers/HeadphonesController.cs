using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HeadphonesStore.Models;
using HeadphonesStore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HeadphonesStore.Controllers
{
    public class HeadphonesController : Controller
    {
        private readonly IHeadphonesRepo _headphonesRepo;
        private readonly ICategoryRepo _categoryRepo;

        public HeadphonesController(IHeadphonesRepo headphonesRepo, ICategoryRepo categoryRepo)
        {
            _headphonesRepo = headphonesRepo;
            _categoryRepo = categoryRepo;
        }
        public ViewResult List(string category)
        {
            IEnumerable<Audio> _headphones;
            string currentCategory;
            if(string.IsNullOrEmpty(category))
            {
                _headphones = _headphonesRepo.GetAll().OrderBy(p => p.HeadphonesId);
                currentCategory = "All headphones";
            }
            else
            {
                _headphones = _headphonesRepo.GetAll().Where(p => p.Category.CategoryName == category).OrderBy(p => p.HeadphonesId);
                currentCategory = _categoryRepo.GetAll().FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }
            return View(new HeadphonesListViewModel            
            {
                Headphones = _headphones,
                CurrentCategory = currentCategory
            });
        }
        public IActionResult Details(int id)
        {
            var headphones = _headphonesRepo.GetHeadphonesById(id);
            if(headphones == null)
            {
                return NotFound();
            }
            return View(headphones);
        }
    }
}