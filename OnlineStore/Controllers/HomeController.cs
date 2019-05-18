using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Data;
using OnlineStore.Data.Interfaces;
using OnlineStore.ViewModels;

namespace OnlineStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
        }

        public IActionResult Details(int productId)
        {
            Product product = _productRepository.Products.SingleOrDefault(prod => prod.ProductId == productId);
            return View(product);
        }

        public IActionResult Index(string category)
        {
            ProductsViewModel view = new ProductsViewModel();

            if (string.IsNullOrEmpty(category))
            {
                view.Products = _productRepository.Products.OrderBy(product => product.ProductId);
                view.CurrentCategory = "All products";
            }
            else
            {
                if (string.Equals("Chordophones", category, StringComparison.OrdinalIgnoreCase))
                {
                    view.Products = _productRepository.Products.Where(product => product.Category.CategoryName
                    .Equals("Chordophones")).OrderBy(product => product.Name);
                }
                if (string.Equals("Membranophones", category, StringComparison.OrdinalIgnoreCase))
                {
                    view.Products = _productRepository.Products.Where(product => product.Category.CategoryName
                    .Equals("Membranophones")).OrderBy(product => product.Name);
                }
                if (string.Equals("Idiophones", category, StringComparison.OrdinalIgnoreCase))
                {
                    view.Products = _productRepository.Products.Where(product => product.Category.CategoryName
                    .Equals("Idiophones")).OrderBy(product => product.Name);
                };
                if (string.Equals("Aerophones", category, StringComparison.OrdinalIgnoreCase))
                {
                    view.Products = _productRepository.Products.Where(product => product.Category.CategoryName
                    .Equals("Aerophones")).OrderBy(product => product.Name);
                }
                view.CurrentCategory = category;
            }
            return View(view);
        }
    }
}