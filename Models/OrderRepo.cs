using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeadphonesStore.Models
{
    public class OrderRepo : IOrderRepo
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepo(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }
        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();

            order.OrderDetails = new List<OrderDetail>();

            foreach(var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Amount = shoppingCartItem.Amount,
                    HeadphonesId = shoppingCartItem.Headphones.HeadphonesId,
                    Price = shoppingCartItem.Headphones.Price
                };
                order.OrderDetails.Add(orderDetail);
            }
            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();
        }
    }
}
