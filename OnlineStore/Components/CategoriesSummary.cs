using Microsoft.AspNetCore.Mvc;
using OnlineStore.Data;
using OnlineStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Components
{
    public class CategoriesSummary : ViewComponent
    {
        private readonly AppDbContext _appDbContext;

        public CategoriesSummary(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        
        public IViewComponentResult Invoke()
        {
            var categories = _appDbContext.Categories;

            var categoriesViewModel = new CategoriesViewModel
            {
                Categories = categories
            };
            return View(categoriesViewModel);
        }
    }
}
