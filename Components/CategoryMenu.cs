using HeadphonesStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeadphonesStore.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepo _categoryRepo;
        public CategoryMenu(ICategoryRepo categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }
        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepo.GetAll().OrderBy(c => c.CategoryName);
            return View(categories);
        }
    }
}
