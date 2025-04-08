using FOLYFOOD.Entitys;

namespace FOLYFOOD.IService.IOrder
{
    public interface OrderStatusInterface
    {
        public Task<IQueryable<OrderStatus>> getOrderStatus();
    }
}
