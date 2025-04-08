using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using FOLYFOOD.Dto;
using FOLYFOOD.Dto.oderDto;
using FOLYFOOD.Dto.oderDto.orderDetailDto;
using FOLYFOOD.Entitys;
using FOLYFOOD.Hellers;
using FOLYFOOD.Hellers.imageChecks;
using FOLYFOOD.Hellers.Mail;
using FOLYFOOD.Hellers.validate;
using FOLYFOOD.IService.IOrder;
using FOLYFOOD.Services.product;
using MailKit.Search;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using System.Data;

namespace FOLYFOOD.Services.order
{
    public class OrderServicer : OrderInterface
    {
        public readonly Context DBContext;
        public readonly ProductService productService;

        public OrderServicer()
        {
            DBContext = new Context();
            productService = new ProductService();
        }
        public async Task<RetunObject<Order>> CreateNewOrder(OrderRequest order)
        {

            try
            {
                if (string.IsNullOrEmpty(order.FullName) || order.Phone == null || order.OrderStatusId == null || order.PaymentId == null || order.orderDetailDtos == null || string.IsNullOrEmpty(order.Address) || string.IsNullOrEmpty(order.Email) || string.IsNullOrEmpty(order.Phone))
                {
                    throw new Exception("dữ liệu truyền lên không đầy đủ");
                }
                foreach (var item in order.orderDetailDtos)
                {
                    if (DBContext.Products.SingleOrDefault(x => x.ProductId == item.ProductId) == null)
                    {
                        throw new Exception("sản phẩm gửi lên không tồn tại");
                    }
                }
                if (DBContext.PaymentOrders.SingleOrDefault(x => x.PaymentId == order.PaymentId) == null)
                {
                    throw new Exception("phương thức thanh toán không tồn tại");
                }
                if (DBContext.OrderStatuses.SingleOrDefault(x => x.OrderStatusId == order.OrderStatusId) == null)
                {
                    throw new Exception("trạng thái hóa đơn không tồn tại");
                }
            }
            catch (Exception ex)
            {
                return new RetunObject<Order>()
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 401
                };
            }

            var orderCreate = new Order()
            {
                CodeOrder = Generate.GenerateOrderCode(),
                OrderStatusId = order.OrderStatusId,
                PaymentOrderPaymentId = order.PaymentId,
                Address = order.Address,
                Email = order.Email,
                ImageComplete = "",
                provinces = order.provinces,
                districts = order.districts,
                ReasonForCancellation = "",
                wards = order.wards,
                pickupTime = order.pickupTime,
                noteOrder = !string.IsNullOrEmpty(order.noteOrder) ? order.noteOrder : "",
                Phone = order.Phone,
                FullName = order.FullName,
                actualPrice = order.actualPrice,
                UserId = order.UserId,
                originalPrice = order.originalPrice,

                
            };
            await DBContext.Orders.AddAsync(orderCreate);
            await DBContext.SaveChangesAsync();
            List<OrderDetail> listOrder = new List<OrderDetail>();
            foreach(OrderDetailRequest detail in order.orderDetailDtos)
            {
                var item = new OrderDetail()
                {
                    OrderId = orderCreate.OrderId,
                    Price = detail.Price,
                    Quantity = detail.Quantity,
                    ProductId = detail.ProductId
                };
                await productService.updateQuantity(item.ProductId, item.Quantity);
                listOrder.Add(item);
            }
            await DBContext.OrderDetails.AddRangeAsync(listOrder);
            await DBContext.SaveChangesAsync();
            await this.getOrderForCodeOrder(orderCreate.CodeOrder);

            return new RetunObject<Order>()
            {
                data = orderCreate,
                mess = "đã tạo hóa đơn thành công",
                statusCode = 201
            };
        }

        public async Task<IQueryable<Order>> GetAllOrders()
        {
            var DataOrder = DBContext.Orders.Include(x => x.OrderDetails).ThenInclude(x => x.Product);
            var res = DataOrder.Include(x => x.OrderDetails).Include(x => x.OrderStatus).AsNoTracking().AsQueryable();
            return res.OrderByDescending(x=>x.CreatedAt);
        }

        public async Task<RetunObject<Order>> getOrderForCodeOrder(string code)
        {
            var dataOne = await DBContext.Orders.Include(x=>x.OrderStatus).Include(x=>x.PaymentOrder).Include(x => x.OrderDetails).ThenInclude(x=>x.Product).FirstOrDefaultAsync(x => x.CodeOrder == code);
            if (dataOne == null)
            {
                return new RetunObject<Order>()
                {
                    data = null,
                    mess = "thông tin hóa đơn không tồn tại",
                    statusCode = 400
                };
            }
            if(ValidateValue.IsValidEmail(dataOne.Email)) {
                SendMail.send(dataOne.Email, OrderEmailTemplate.GenerateOrderEmail(dataOne,"thông báo đơn"), "foly food");
            }
            return new RetunObject<Order>()
            {
                data = dataOne,
                mess = "đã lấy được hóa đơn thành công",
                statusCode = 201
            }; ;
        }

        public async Task<RetunObject<Order>> CompleteOrder(CompleteOrderRequest value)
        {
            var dataOne = DBContext.Orders.FirstOrDefault(x => x.OrderId == value.OrderId);
            var OrderDetail = DBContext.OrderDetails.Where(x => x.OrderId == value.OrderId).Include(x => x.Product);
            var PaymentOrder = DBContext.PaymentOrders.FirstOrDefault(x => x.PaymentId == dataOne.PaymentOrderPaymentId);
            var statusOrder = DBContext.OrderStatuses.FirstOrDefault(x => x.OrderStatusId == dataOne.OrderStatusId);
            dataOne.OrderDetails = OrderDetail.ToArray();
            dataOne.OrderStatus = statusOrder;
            dataOne.PaymentOrder = PaymentOrder;
            try
            {
                if (dataOne == null)
                {
                    throw new Exception("đơn hàng không tồn tại");
                }
                if (DBContext.OrderStatuses.SingleOrDefault(x => x.OrderStatusId == 5) == null)
                {
                    throw new Exception("trạng thái chưa được định nghĩa");
                }
            }
            catch (Exception ex)
            {
                return new RetunObject<Order>()
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 401
                };
            }
            int imageSize = 2 * 1024 * 1024;
            if (!ImageChecker.IsImage(value.formFile, imageSize))
            {
                return null;
            };
            var avatarFile = value.formFile;

            string imageUrl = await uplloadFile.UploadFile(avatarFile);
            dataOne.OrderStatusId = 5;
            dataOne.ImageComplete = imageUrl;
            DBContext.Orders.Update(dataOne);
            DBContext.SaveChanges();
            if (ValidateValue.IsValidEmail(dataOne.Email))
            {
                SendMail.send(dataOne.Email, OrderEmailTemplate.GenerateOrderEmail(dataOne, "Cập nhật trạng thái đơn"), "foly food");
            }
            return new RetunObject<Order>()
            {
                data = dataOne,
                mess = "trạng thái đã được thay đổi",
                statusCode = 201
            };
        }

        public async Task<RetunObject<Order>> updateStatusOrder(int orderId, int statusId)
        {
            var dataOne = DBContext.Orders.FirstOrDefault(x => x.OrderId == orderId);
            var OrderDetail = DBContext.OrderDetails.Where(x => x.OrderId == orderId).Include(x => x.Product);
            var PaymentOrder = DBContext.PaymentOrders.FirstOrDefault(x => x.PaymentId == dataOne.PaymentOrderPaymentId);
            var statusOrder = DBContext.OrderStatuses.FirstOrDefault(x => x.OrderStatusId == dataOne.OrderStatusId);
            dataOne.OrderDetails = OrderDetail.ToArray();
            dataOne.OrderStatus = statusOrder;
            dataOne.PaymentOrder = PaymentOrder;
            try
            {
                if(dataOne == null)
                {
                    throw new Exception("đơn hàng không tồn tại");
                }
                if(DBContext.OrderStatuses.SingleOrDefault(x=>x.OrderStatusId == statusId) == null)
                {
                    throw new Exception("trạng thái chưa được định nghĩa");
                }
            }
            catch (Exception ex)
            {
                return new RetunObject<Order>()
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 401
                };
            }
            dataOne.OrderStatusId = statusId;
            DBContext.Orders.Update(dataOne);
            DBContext.SaveChanges();
            if (ValidateValue.IsValidEmail(dataOne.Email))
            {
                SendMail.send(dataOne.Email, OrderEmailTemplate.GenerateOrderEmail(dataOne, "Cập nhật trạng thái đơn"), "foly food");
            }
           
            return new RetunObject<Order>()
            {
                data = dataOne,
                mess = "trạng thái đã được thay đổi",
                statusCode = 201
            };
        }
        public async Task<IQueryable<Order>> orderIsCanceled()
        {
            var DataOrder = DBContext.Orders.Where(x=>x.OrderStatusId == 7).Include(x => x.OrderDetails).ThenInclude(x => x.Product);
            var res = DataOrder.Include(x => x.OrderDetails).Include(x => x.OrderStatus).AsNoTracking().AsQueryable();
            return res.OrderByDescending(x => x.CreatedAt);
        }
        public async Task<IQueryable<Order>> OrderHasBeenConfirmed()
        {
            var DataOrder = DBContext.Orders.Where(x => x.OrderStatusId == 15).Include(x => x.OrderDetails).ThenInclude(x => x.Product);
            var res = DataOrder.Include(x => x.OrderDetails).Include(x => x.OrderStatus).AsNoTracking().AsQueryable();
            return res.OrderByDescending(x => x.CreatedAt);
        }
        public async Task<IQueryable<Order>> OrderCanceledByCustomer()
        {
            var DataOrder = DBContext.Orders.Where(x => x.OrderStatusId == 12).Include(x => x.OrderDetails).ThenInclude(x => x.Product);
            var res = DataOrder.Include(x => x.OrderDetails).Include(x => x.OrderStatus).AsNoTracking().AsQueryable();
            return res.OrderByDescending(x => x.CreatedAt);
        }
        public async Task<IQueryable<Order>> getOrdersAreBeingDelivered()
        {
            var DataOrder = DBContext.Orders.Where(x => x.OrderStatusId == 9).Include(x => x.OrderDetails).ThenInclude(x => x.Product);
            var res = DataOrder.Include(x => x.OrderDetails).Include(x => x.OrderStatus).AsNoTracking().AsQueryable();
            return res.OrderByDescending(x => x.CreatedAt);
        }
        public async Task<IQueryable<Order>> getWaitingOrder()
        {
            var DataOrder = DBContext.Orders.Where(x => x.OrderStatusId == 4).Include(x => x.OrderDetails).ThenInclude(x => x.Product);
            var res = DataOrder.Include(x => x.OrderDetails).Include(x => x.OrderStatus).AsNoTracking().AsQueryable();
            return res.OrderByDescending(x => x.CreatedAt);
        }
        public async Task<IQueryable<Order>> getOrderComplete()
        {
            var DataOrder = DBContext.Orders.Where(x => x.OrderStatusId == 5).Include(x => x.OrderDetails).ThenInclude(x => x.Product);
            var res = DataOrder.Include(x => x.OrderDetails).Include(x => x.OrderStatus).AsNoTracking().AsQueryable();
            return res.OrderByDescending(x => x.CreatedAt);
        }
        public async Task<IQueryable<Order>> GetOrderForUserId(int id,string accountId,string role,string? searchCode)
        {  
            var user  = DBContext.Accounts.Include(x=>x.User).AsNoTracking().SingleOrDefault(x=>x.AccountId == id);
            if(role != "admin")
            {
              
                if(int.Parse(accountId) != user.AccountId)
                {
                    return null;
                }
            }
            var resOrder = DBContext.Orders.Where(x => x.UserId == user.User.UserId).Include(x => x.OrderStatus).Include(x => x.PaymentOrder).Include(x => x.OrderDetails).ThenInclude(x => x.Product).OrderByDescending(x => x.CreatedAt).AsNoTracking().AsQueryable();
            if (!searchCode.IsNullOrEmpty())
            {
                resOrder = resOrder.Where(x=>x.CodeOrder == searchCode).AsNoTracking().AsQueryable();
            }
            return resOrder;
        }

        public async Task<RetunObject<Order>> cancelOrder(string code, string accountId, string role,string message) {
            var dataOne = DBContext.Orders.FirstOrDefault(x => x.CodeOrder == code);
         
          
           
            var user = DBContext.Users.FirstOrDefault(x => x.UserId == dataOne.UserId);

        
         
            try
            {
                if (dataOne == null)
                {
                    throw new Exception("đơn hàng không tồn tại");
                }
                if (role != "admin")
                {
                    if (int.Parse(accountId) != user.AccountId)
                    {
                        throw new Exception("bạn không quyền hủy đơn hàng của người khác");
                    }
                }
                DateTime currentDate = DateTime.Now;
                DateTime availableDate = dataOne.CreatedAt;
                TimeSpan difference = currentDate - availableDate;
                int daysDifference = (int)difference.TotalDays;
                if (daysDifference > 2)
                {
                    throw new Exception("Đơn hàng của quý khách đã quá hạn để hủy.");
                }
                if(string.IsNullOrEmpty(message))
                {
                    throw new Exception("Không tồn tại lý do để hủy.");
                }
                if (dataOne.OrderStatusId !=4)
                {
                    throw new Exception("Đơn hàng của đã được sử lý rồi không được hủy.");
                }
            }
            catch (Exception ex)
            {
                return new RetunObject<Order>()
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 401
                };
            }
            dataOne.OrderStatusId = 12;
            dataOne.ReasonForCancellation = message;
            DBContext.Orders.Update(dataOne);
            DBContext.SaveChanges();
            if (ValidateValue.IsValidEmail(dataOne.Email))
            {
                SendMail.send(dataOne.Email, CancelOrderTheme.ThemeSendMail(dataOne.FullName, dataOne.CodeOrder), "foly food");
            }

            return new RetunObject<Order>()
            {
                data = dataOne,
                mess = "trạng thái đã được thay đổi",
                statusCode = 201
            };
        }

        public async Task<IQueryable<OrderDetail>> getDetail(int id)
        {
            var dataOne = DBContext.OrderDetails.Where(x=>x.OrderId == id).Include(x=>x.Product).AsQueryable();
            if(dataOne == null)
            {
                return null;
            }
           return dataOne;
        }

        public async Task<Boolean> IsUserPurchasedProduct(int userId, int productId)
        {
            bool isPurchased = DBContext.Orders
                .Any(o => o.UserId == userId && o.OrderDetails.Any(od => od.ProductId == productId) && o.OrderStatusId == 5);

            return isPurchased;
        }
    }
}
