using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Data;
using OnlineStore.Data.Interfaces;
using OnlineStore.Data.Models;
using OnlineStore.Data.Repositories;
using OnlineStore.ViewModels;

namespace OnlineStore.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IProductRepository productRepository, ShoppingCart shoppingCart)
        {
            _productRepository = productRepository;
            _shoppingCart = shoppingCart;
        }

        public IActionResult Index()
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

        public RedirectToActionResult AddToShoppingCart(int productId)
        {
            var product = _productRepository.Products
                .FirstOrDefault(prod => prod.ProductId == productId);

            if (product != null)
            {
                _shoppingCart.AddToCart(product);
            }
             
            return RedirectToAction("Index");
        }

        public RedirectToActionResult Increase(int productId)
        {
            var product = _productRepository.Products
                .FirstOrDefault(prod => prod.ProductId == productId);

            if (product != null)
            {
                _shoppingCart.IncreaseAmount(product);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult Decrease(int productId)
        {
            var product = _productRepository.Products
                .FirstOrDefault(prod => prod.ProductId == productId);

            if (product != null)
            {
                _shoppingCart.DecreaseAmount(product);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int productId)
        {
            var product = _productRepository.Products
                .FirstOrDefault(p => p.ProductId == productId);

            if (product != null)
            {
                _shoppingCart.RemoveFromCart(product);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult ClearShoppingCart()
        {
            _shoppingCart.ClearCart();

            return RedirectToAction("Index");
        }
    }
}