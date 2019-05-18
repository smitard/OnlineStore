using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Data;
using OnlineStore.Data.Models;
using Newtonsoft.Json;
using OnlineStore.ViewModels;

namespace OnlineStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ShoppingCart _shoppingCart;

        public OrderController(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }
        [Route("get")]
        public string Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            List<Order> order = new List<Order>();

            foreach (var item in items)
            {
                order.Add(
                    new Order
                    {
                        Quantity = item.Quantity,
                        ProductId = item.Product.ProductId,
                        Name = item.Product.Name
                    }
                    );
            }

            return JsonConvert.SerializeObject(order);
        }
    }
}