using ZippySip.Models;

namespace ZippySip.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
