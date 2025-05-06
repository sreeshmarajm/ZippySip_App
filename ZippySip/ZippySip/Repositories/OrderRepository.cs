using ZippySip.Interfaces;
using ZippySip.Models;

namespace ZippySip.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;
        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced=DateTime.Now;
            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();
            var shoppingCartItems=_shoppingCart.ShoppingCartItems;
            foreach(var item  in shoppingCartItems)
            {
                var orderDetail = new OrderDetails()
                {
                    Amount = item.Amount,
                    DrinkId = item.Drink.DrinkId,
                    OrderId = order.OrderId,
                    Price = (decimal)item.Drink.Price,
                };
                _appDbContext.OrderDetails.Add(orderDetail);
                
            }
            _appDbContext.SaveChanges();
        }
    }
}
