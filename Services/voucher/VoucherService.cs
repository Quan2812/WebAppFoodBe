using FOLYFOOD.Dto;
using FOLYFOOD.Dto.voucherDto;
using FOLYFOOD.Entitys;
using FOLYFOOD.Hellers;
using FOLYFOOD.Hellers.Mail;
using FOLYFOOD.Hellers.validate;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace FOLYFOOD.Services.voucher
{
    public class VoucherService
    {
        public readonly Context DBContext;
        public VoucherService()
        {
            DBContext = new Context();
        }

        public async Task<IQueryable<Voucher>> GetVoucher()
        {
            return DBContext.Vouchers.Include(x => x.VoucherUsers).ThenInclude(x => x.User).ThenInclude(x => x.Account).AsNoTracking();
        }
        public async Task<RetunObject<Voucher>> CreateVoucher(VoucherCreateRequest value)
        {
            UniqueStringGenerator generator = new UniqueStringGenerator();
            string codeGenerator = "";
            try
            {
                if (value.Valuevoucher < 0 || value.Valuevoucher > 100)
                {
                    throw new ArgumentException("vui lòng giá trị quá 100% hoặc thấp hơn 0%");
                }
                if (value.CountVoucher < 0)
                {
                    throw new ArgumentException("số lượng khuyến mại không được là số âm");
                }
                if (string.IsNullOrEmpty(value.VoucherName))
                {
                    throw new ArgumentException("vui lòng nhập tên voucher");
                }
                DateTime nowUtc = DateTime.UtcNow; // Lấy thời gian hiện tại ở múi giờ UTC
                TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"); // Múi giờ Việt Nam (UTC+7)

                DateTime nowVietnam = TimeZoneInfo.ConvertTimeFromUtc(nowUtc, vietnamTimeZone); // Chuyển thời gian hiện tại sang múi giờ Việt Nam
                if (value.expirationDate < nowVietnam)
                {
                    throw new ArgumentException("thời gian nhập vào không hợp lệ");
                }


            }
            catch (Exception ex)
            {
                return new RetunObject<Voucher>()
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 400
                };
            }
            do
            {
                codeGenerator = generator.GenerateUniqueString(8);
            }
            while (DBContext.Vouchers.Any(x => x.VoucherCode == codeGenerator));

            Voucher voucher = new Voucher()
            {
                VoucherCode = codeGenerator,
                VoucherName = value.VoucherName,
                CountVoucher = value.CountVoucher,
                Valuevoucher = value.Valuevoucher,
                expirationDate = value.expirationDate,
            };
            await DBContext.Vouchers.AddAsync(voucher);
            await DBContext.SaveChangesAsync();
            return new RetunObject<Voucher>()
            {
                data = voucher,
                mess = "tạo khuyến mại thành công",
                statusCode = 200
            };
        }
        public async Task<RetunObject<User>> sendMailPromotionToUser (int UserId, int VoucherId)
        {
            var Voucher = DBContext.Vouchers.SingleOrDefault(x => x.voucherId == VoucherId);
            var user = DBContext.Users.Include(x=>x.Account).SingleOrDefault(x => x.UserId == UserId);
            if (user == null)
            {
                return new RetunObject<User>()
                {
                    data = null,
                    mess = "người dùng không tồn tại",
                    statusCode = 400
                };
            }

            if(Voucher == null)
            {
                return new RetunObject<User>()
                {
                    data = null,
                    mess = "thông tin khuyến mãi không tồn tại",
                    statusCode = 400
                };
            }
            if (ValidateValue.IsValidEmail(user.Email))
            {
                SendMail.send(user.Email,EmailSendPromotionThemeUser.ThemeSendMail(Voucher.VoucherCode,Voucher.Valuevoucher, user.UserName == "" ? user.Account.UserName : user.UserName), "foly food");
            }
            return new RetunObject<User>()
            {
                data = user,
                mess = "Đã gửi mail thành công",
                statusCode = 200
            };
        }
        public async Task<IQueryable<User>> GetUsersWithoutPromotionUsage(int voucherId)
        {
            return DBContext.Users
        .Where(user => user.VoucherUsers.All(voucherUser => voucherUser.voucherId != voucherId) && user.Account.Status == 1).Include(x=>x.Account).AsNoTracking();
        }
        public async Task<RetunObject<Voucher>> UseVoucher(int userId, string codeVoucher)
        {
            DateTime nowUtc = DateTime.UtcNow; // Lấy thời gian hiện tại ở múi giờ UTC
            TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"); // Múi giờ Việt Nam (UTC+7)

            DateTime nowVietnam = TimeZoneInfo.ConvertTimeFromUtc(nowUtc, vietnamTimeZone); // Chuyển thời gian hiện tại sang múi giờ Việt Nam
            var Voucher = DBContext.Vouchers.SingleOrDefault(x => x.VoucherCode == codeVoucher && x.expirationDate > nowVietnam );
            try
            {
                if (Voucher == null)
                {
                    throw new Exception("khuyến mại không tồn tại");
                }
                if (DBContext.Users.SingleOrDefault(x => x.UserId == userId) == null)
                {
                    throw new Exception("người dùng không tồn tại");
                }
                if (Voucher.CountVoucher <= 0)
                {
                    throw new Exception("Hết voucher rồi");
                }
                if (DBContext.VoucherUsers.SingleOrDefault(x => x.UserId == userId && x.voucherId == Voucher.voucherId) != null)
                {
                    throw new Exception("khuyến mại đã được bạn sử dụng trước đó");
                }
            }
            catch (Exception ex)
            {
                return new RetunObject<Voucher>()
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 400
                };

            }
            return new RetunObject<Voucher>()
            {
                data = Voucher,
                mess = "tạo khuyến mại thành công",
                statusCode = 200
            };
        }

        public async Task<RetunObject<VoucherUser>> ApplyVoucher(int userId, string codeVoucher)
        {
            DateTime nowUtc = DateTime.UtcNow; // Lấy thời gian hiện tại ở múi giờ UTC
            TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"); // Múi giờ Việt Nam (UTC+7)

            DateTime nowVietnam = TimeZoneInfo.ConvertTimeFromUtc(nowUtc, vietnamTimeZone); // Chuyển thời gian hiện tại sang múi giờ Việt Nam
            var Voucher = DBContext.Vouchers.SingleOrDefault(x => x.VoucherCode == codeVoucher && x.expirationDate > nowVietnam);
            try
            {
                if (Voucher == null)
                {
                    throw new Exception("khuyến mại không tồn tại");
                }
                if (DBContext.Users.SingleOrDefault(x => x.UserId == userId) == null)
                {
                    throw new Exception("người dùng không tồn tại");
                }
            }
            catch (Exception ex)
            {
                return new RetunObject<VoucherUser>()
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 400
                };

            }
            VoucherUser voucherUser = new VoucherUser()
            {
                UserId = userId,
                voucherId = Voucher.voucherId
            };
            await DBContext.VoucherUsers.AddAsync(voucherUser);
            await DBContext.SaveChangesAsync();

            Voucher.CountVoucher = Voucher.CountVoucher - 1;
            DBContext.Update(Voucher);
            await DBContext.SaveChangesAsync();
            return new RetunObject<VoucherUser>()
            {
                data = voucherUser,
                mess = "áp dụng khuyến mại thành công",
                statusCode = 200
            };
        }
        public async Task<RetunObject<Voucher>> DeleteVoucher(int VoucherId)
        {
            var Voucher = DBContext.Vouchers.SingleOrDefault(x => x.voucherId == VoucherId);
            IQueryable<VoucherUser> VoucherUser = DBContext.VoucherUsers.Where(x => x.voucherId == VoucherId);
            if (Voucher == null)
            {
                return new RetunObject<Voucher>()
                {
                    data = null,
                    mess = "xóa thất bại do không tồn tại khuyến mại",
                    statusCode = 400
                };
            }
            if (VoucherUser.Count() > 0)
            {
                DBContext.VoucherUsers.RemoveRange(VoucherUser);
                await DBContext.SaveChangesAsync();
            }
            DBContext.Vouchers.Remove(Voucher);
            await DBContext.SaveChangesAsync();

            return new RetunObject<Voucher>()
            {
                data = Voucher,
                mess = "xóa thành công",
                statusCode = 200
            };
        }

    }
}
