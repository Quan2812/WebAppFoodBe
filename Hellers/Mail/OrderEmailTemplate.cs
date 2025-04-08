using FOLYFOOD.Entitys;

namespace FOLYFOOD.Hellers.Mail
{
    public class OrderEmailTemplate
    {
        public static string GenerateOrderEmail(Order order, string mess = "")
        {
            string htmlContent = $@"
            <html>
            <head>
                <style>
                    /* CSS cho giao diện email */
                    body {{
                        font-family: Arial, sans-serif;
                    }}
                    image {{
                        width: 60px;
                        height: 70px;
                    }}
                    h1 {{
                        color: #333;
                    }}
                    
                    table {{
                        border-collapse: collapse;
                        width: 100%;
                    }}
                    
                    th, td {{
                        border: 1px solid #ddd;
                        padding: 8px;
                    }}
                    
                    th {{
                        background-color: #f2f2f2;
                        font-weight: bold;
                    }}
                    
                    .footer {{
                        margin-top: 20px;
                        font-size: 14px;
                    }}
                </style>
            </head>
            <body>
                <h1>Thông tin đơn hàng</h1>
                <h2 style=""color: red; font-size: 20px; font-weight: bold;"">{(string.IsNullOrEmpty(mess) ? "" : mess)}</h2>

                <table>
                    <tr>
                        <th>Mã đơn hàng</th>
                        <th>Mã đơn hàng (Code)</th>
                        <th>Phương thức thanh toán</th>
                        <th>Trạng thái đơn hàng</th>
                        <th>Giá gốc</th>
                        <th>Giá thực tế</th>
                        <th>Ngày tạo</th>
                        <th>Tên người đặt</th>
                        <th>Số điện thoại</th>
                        <th>Địa chỉ</th>
                    </tr>
                    <tr>
                        <td>{order.OrderId}</td>
                        <td>{order.CodeOrder}</td>
                        <td>{order.PaymentOrder.PaymentTitle}</td>
                        <td>{order.OrderStatus.Name}</td>
                        <td>{order.originalPrice}</td>
                        <td>{order.actualPrice}</td>
                        <td>{order.CreatedAt}</td>
                        <td>{order.FullName}</td>
                        <td>{order.Phone}</td>
                        <td>{order.Address}</td>
                    </tr>
                </table>
                
                <h2>Danh sách sản phẩm</h2>
                <table>
                    <tr>
                        <th>Mã sản phẩm</th>
                        <th>Tên sản phẩm</th>
                        <th>Số lượng</th>
                        <th>Giá</th>
                    </tr>";

            foreach (var detail in order.OrderDetails)
            {
                htmlContent += $@"
                    <tr>
                        <td>{detail.ProductId}</td>
                        <td>{detail.Product.NameProduct}</td>
                        <td>{detail.Quantity}</td>
                        <td>{detail.Price}</td>
                    </tr>";
            }

            htmlContent += $@"
                       <tr>
                        <td style=""text-align: center;"">tổng tiền</td>
                        <td colspan=""3"" style=""text-align: right;"">{order.actualPrice}</td>
                    </tr>
                </table>
                
                <div class=""footer"">
                    <p>Trân trọng,</p>
                    <p>Đội ngũ Poly Food</p>
                </div>
            </body>
            </html>";

            return htmlContent;
        }
    }

}
