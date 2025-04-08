using FOLYFOOD.Entitys;
using FOLYFOOD.IService.IOrder;
using Microsoft.EntityFrameworkCore;

namespace FOLYFOOD.Services.order
{
    public class OrderStatusServicer : OrderStatusInterface
    {
        public readonly Context DBContext;

        public OrderStatusServicer()
        {
            DBContext = new Context();
        }
        public async Task<IQueryable<OrderStatus>> getOrderStatus()
        {
            var res = DBContext.OrderStatuses.AsNoTracking().AsQueryable();
           return res;
        }
    }
}
