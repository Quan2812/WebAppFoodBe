using FOLYFOOD.Dto.StatisticsDto;
using FOLYFOOD.Entitys;
using Microsoft.EntityFrameworkCore;
using System.Dynamic;

namespace FOLYFOOD.Services.statistics
{
    public class StatisticsService
    {
        public readonly Context DBContext;

        public StatisticsService()
        {
            DBContext = new Context();
        }
        public List<ProductSale> GetTopSellingProducts(DateTime? startDate = null, DateTime? endDate = null)
        {
            if (startDate == null)
            {
                startDate = DateTime.Now.AddMonths(-1).Date; // Tháng trước
            }

            if (endDate == null)
            {
                endDate = DateTime.Now.Date; // Tháng hiện tại
            }

            using (var dbContext = new Context())
            {
                var totalQuantity = dbContext.OrderDetails
                    .Where(od => od.Order.CreatedAt >= startDate && od.Order.CreatedAt <= endDate && od.Order.OrderStatusId == 5)
                    .Sum(od => od.Quantity);

                var topSellingProducts = dbContext.OrderDetails
                    .Where(od => od.Order.CreatedAt >= startDate && od.Order.CreatedAt <= endDate && od.Order.OrderStatusId == 5)
                    .GroupBy(od => od.ProductId)
                    .Select(g => new ProductSale
                    {
                        ProductId = g.Key,
                        TotalQuantity = g.Sum(od => od.Quantity),
                        SalePercentage = (double)g.Sum(od => od.Quantity) / totalQuantity * 100
                    })
                    .OrderByDescending(p => p.TotalQuantity)
                    .Take(10)
                    .Join(dbContext.Products, p => p.ProductId, pr => pr.ProductId, (p, pr) => new ProductSale
                    {
                        ProductId = p.ProductId,
                        TotalQuantity = p.TotalQuantity,
                        SalePercentage = p.SalePercentage,
                        Product = pr
                    })
                    .ToList();

                return topSellingProducts;
            }
        }
        public List<dynamic> CalculateMonthlyRevenueAndOrderCount(DateTime? startDate = null, DateTime? endDate = null, int? orderStatusId = 5)
        {
            if (startDate == null)
            {
                startDate = DateTime.Now.AddMonths(-12).Date; // 12 tháng trước
            }
            if (endDate == null)
            {
                endDate = DateTime.Now.Date; // Ngày hiện tại
            }

            DateTime currentStartDate = startDate.Value;
            DateTime currentEndDate = new DateTime(currentStartDate.Year, currentStartDate.Month, DateTime.DaysInMonth(currentStartDate.Year, currentStartDate.Month));

            List<dynamic> monthlyData = new List<dynamic>();

            while (currentStartDate <= endDate && currentStartDate <= currentEndDate)
            {
                string monthYear = currentStartDate.ToString("MM/yyyy");

                // Code xử lý tính toán doanh thu và số lượng đơn hàng trong tháng
                // Sử dụng currentStartDate và currentEndDate trong truy vấn và tính tổng giá trị actualPrice và số lượng đơn hàng

                // Ví dụ: Tính tổng actualPrice và số lượng đơn hàng trong tháng hiện tại với trạng thái đơn hàng cụ thể
                var data = DBContext.Orders
                    .Where(o => o.CreatedAt >= currentStartDate && o.CreatedAt <= currentEndDate && (orderStatusId == null || o.OrderStatusId == orderStatusId))
                    .GroupBy(o => o.CreatedAt.Month)
                    .Select(g => new
                    {
                        Revenue = g.Sum(o => o.actualPrice),
                        OrderCount = g.Count()
                    })
                    .FirstOrDefault();

                dynamic monthlyRecord = new ExpandoObject();
                monthlyRecord.MonthYear = monthYear;
                monthlyRecord.Revenue = data?.Revenue ?? 0;
                monthlyRecord.OrderCount = data?.OrderCount ?? 0;

                monthlyData.Add(monthlyRecord);

                currentStartDate = currentEndDate.AddDays(1); // Chuyển sang tháng tiếp theo
                currentEndDate = new DateTime(currentStartDate.Year, currentStartDate.Month, DateTime.DaysInMonth(currentStartDate.Year, currentStartDate.Month));
            }

            return monthlyData;
        }
        public List<OrderStatusData> CalculateOrderStatusData(DateTime? startDate = null, DateTime? endDate = null)
        {
            if (startDate == null)
            {
                startDate = DateTime.MinValue; // Ngày nhỏ nhất
            }
            if (endDate == null)
            {
                endDate = DateTime.MaxValue; // Ngày lớn nhất
            }

            List<OrderStatusData> orderStatusDataList = new List<OrderStatusData>();

            // Lấy danh sách các trạng thái đơn hàng
            List<OrderStatus> orderStatuses = DBContext.OrderStatuses.ToList();

            // Tính tổng số đơn hàng và tỷ lệ phần trăm cho mỗi trạng thái
            foreach (var orderStatus in orderStatuses)
            {
                int orderCount = DBContext.Orders.Count(o => o.OrderStatusId == orderStatus.OrderStatusId &&
                                                            o.CreatedAt >= startDate && o.CreatedAt <= endDate);

                if (orderCount > 0)
                {
                    OrderStatusData orderStatusData = new OrderStatusData()
                    {
                        OrderStatus = orderStatus.Name,
                        OrderCount = orderCount
                    };

                    orderStatusDataList.Add(orderStatusData);
                }
            }

            // Tính tỷ lệ phần trăm đơn hàng cho mỗi trạng thái
            int totalOrderCount = orderStatusDataList.Sum(o => o.OrderCount);
            foreach (var item in orderStatusDataList)
            {
                if (totalOrderCount > 0)
                {
                    double ratio = (double)item.OrderCount / totalOrderCount * 100;
                    item.Ratio = ratio;
                }
                else
                {
                    item.Ratio = 0; // Gán tỷ lệ là 0 khi totalOrderCount = 0
                }
            }

            return orderStatusDataList;
        }
        public StatisticsData GetStatisticsData()
        {
            var data = new StatisticsData();
            data.OrderCount = DBContext.Orders.Count(x=>x.OrderStatusId != 7);
            data.UserCount = DBContext.Accounts.Count(x => x.DecentralizationId == 3);
            data.ProductCount = DBContext.Products.Count();
            data.Revenue = DBContext.Orders
                    .Where(x => x.OrderStatusId == 5).Sum(x=>x.actualPrice);
            return data;
        }
        public List<MonthAccountCount> GetAccountCountsByMonth(DateTime? startDate, DateTime? endDate)
        {
            List<MonthAccountCount> accountCountsByMonth = new List<MonthAccountCount>();
            if (startDate == null)
            {
                startDate = DateTime.Now.AddMonths(-6).Date; // 12 tháng trước
            }
            if (endDate == null)
            {
                endDate = DateTime.Now.Date; // Ngày hiện tại
            }

            var query = from account in DBContext.Accounts
                        where account.CreatedAt >= startDate && account.CreatedAt <= endDate && account.DecentralizationId != 1
                        group account by new { account.CreatedAt.Year, account.CreatedAt.Month } into g
                        select new { Month = new DateTime(g.Key.Year, g.Key.Month, 1), Count = g.Count() };

            foreach (var item in query)
            {
                MonthAccountCount monthAccountCount = new MonthAccountCount
                {
                    Month = item.Month,
                    Count = item.Count
                };
                accountCountsByMonth.Add(monthAccountCount);
            }

            return accountCountsByMonth;
        }

        public Dictionary<DateTime, List<UserOrderCount>> GetOrderCountsByUserAndMonth()
        {
            DateTime currentDate = DateTime.Now;
            DateTime sixMonthsAgo = currentDate.AddMonths(-6);

            var query = from order in DBContext.Orders
                        where order.CreatedAt >= sixMonthsAgo && order.CreatedAt <= currentDate && order.UserId != null
                        group order by new { order.UserId, Month = new DateTime(order.CreatedAt.Year, order.CreatedAt.Month, 1) } into g
                        select new UserOrderCount
                        {
                            account = g.FirstOrDefault().User.Account,
                            OrderCount = g.Count(),
                            OrderTongTien = g.Sum(o => o.actualPrice),
                            Month = g.Key.Month
                        };

            var userOrderCountsByMonth = query.ToList()
                .GroupBy(uoc => uoc.Month)
                .ToDictionary(g => g.Key, g => g.ToList());

            return userOrderCountsByMonth;
        }



    }
}
