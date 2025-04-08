using FOLYFOOD.Dto;
using FOLYFOOD.Dto.oderDto;
using FOLYFOOD.Entitys;

namespace FOLYFOOD.IService.IOrder
{
    public interface OrderInterface
    {
        public Task<RetunObject<Order>> CreateNewOrder(OrderRequest order);
        public Task<RetunObject<Order>> updateStatusOrder(int orderId,int statusId);
        public Task<IQueryable<Order>> GetAllOrders();
        public Task<RetunObject<Order>> getOrderForCodeOrder(string code);
        public Task<RetunObject<Order>> cancelOrder(string code, string accountId, string role, string message);
        public Task<IQueryable<Order>> GetOrderForUserId(int id, string accountId, string role,string? searchCode);
        public Task<IQueryable<OrderDetail>> getDetail(int id);
        public Task<Boolean> IsUserPurchasedProduct(int userId, int productId);
        public Task<IQueryable<Order>> getWaitingOrder();

        public Task<IQueryable<Order>> getOrdersAreBeingDelivered();
        public Task<IQueryable<Order>> getOrderComplete();

        public Task<IQueryable<Order>> orderIsCanceled();

    }
}
