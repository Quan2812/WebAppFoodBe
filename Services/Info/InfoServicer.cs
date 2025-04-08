using FOLYFOOD.Dto;
using FOLYFOOD.Dto.InfoDto;
using FOLYFOOD.Entitys;
using FOLYFOOD.Hellers.validate;
using FOLYFOOD.IService.IInfo;
using Microsoft.EntityFrameworkCore;

namespace FOLYFOOD.Services.Info
{
    public class InfoServicer : InfoInterface
    {
        public readonly Context DBContext;

        public InfoServicer()
        {
            DBContext = new Context();
        }
        public async Task<RetunObject<Entitys.Info>> addInfo(InfoRequets info)
        {
            try
            {
                if (string.IsNullOrEmpty(info.Address1) || string.IsNullOrEmpty(info.Address2) || string.IsNullOrEmpty(info.Email) || string.IsNullOrEmpty(info.Title))
                {
                    throw new Exception("thông tin người dùng nhập vào không đầy đủ");
                }
                if (!ValidateValue.IsValidEmail(info.Email))
                {
                    throw new Exception("định dạng email không đúng");
                }
                if (!ValidateValue.IsValidPhoneNumber(info.Phone))
                {
                    throw new Exception("định dạng phone không đúng");
                }
            }

            catch (Exception ex)
            {
                return new RetunObject<Entitys.Info>()
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 404
                };
            }
            Entitys.Info infos = new Entitys.Info()
            {
                Phone = info.Phone,
                Address1 = info.Address1,
                Address2 = info.Address2,
                Email = info.Email,
                IsShow = false,
                Title = info.Title,
            };
            await DBContext.Infos.AddAsync(infos);
            await DBContext.SaveChangesAsync();
            return new RetunObject<Entitys.Info>()
            {
                data = infos,
                mess = "Làm tốt lắm người anh em",
                statusCode = 201
            };
        }

        public async Task<RetunObject<Entitys.Info>> deleteInfo(int infoId)
        {
            Entitys.Info info = await DBContext.Infos.SingleOrDefaultAsync(x => x.InfoId == infoId);
            try
            {
                if (info == null)
                {
                    throw new Exception("thông tin info không tồn tại");
                }
                if (info.IsShow)
                {
                    throw new Exception("Thông tin cửa hàng đang được sử dụng");
                }

            }

            catch (Exception ex)
            {
                return new RetunObject<Entitys.Info>()
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 404
                };
            }
            DBContext.Remove(info);
            await DBContext.SaveChangesAsync();
            return new RetunObject<Entitys.Info>()
            {
                data = info,
                mess = "dữ liệu đã được hiển thị thành công",
                statusCode = 200
            };
        }

        public async Task<IQueryable<Entitys.Info>> getAllInfo()
        {
            var infos = DBContext.Infos.OrderByDescending(x => x.IsShow).AsQueryable();
            return infos.AsQueryable();
        }

        public async Task<RetunObject<Entitys.Info>> getInfo()
        {
            Entitys.Info info = await DBContext.Infos.SingleOrDefaultAsync(x => x.IsShow);
            try
            {
                if (info == null)
                {
                    throw new Exception("thông tin info không tồn tại");
                }

            }

            catch (Exception ex)
            {
                return new RetunObject<Entitys.Info>()
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 404
                };
            }
            return new RetunObject<Entitys.Info>()
            {
                data = info,
                mess = "dữ liệu đã được hiển thị thành công",
                statusCode = 200
            };
        }

        public async Task<RetunObject<Entitys.Info>> showInfo(int infoId)
        {
            Entitys.Info info = await DBContext.Infos.SingleOrDefaultAsync(x => x.InfoId == infoId);
            try
            {
                if (info == null)
                {
                    throw new Exception("thông tin info không tồn tại");
                }

                if (info.IsShow)
                {
                    throw new Exception("chọn thằng khác đi cái này mày chọn rồi");
                }

            }

            catch (Exception ex)
            {
                return new RetunObject<Entitys.Info>()
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 404
                };
            }
            await DBContext.Database.ExecuteSqlAsync($@"UPDATE Infos  SET IsShow = 0");
            info = await DBContext.Infos.SingleOrDefaultAsync(x => x.InfoId == infoId);
            info.IsShow = !info.IsShow;
            DBContext.Update(info);
            DBContext.SaveChanges();
            return new RetunObject<Entitys.Info>()
            {
                data = info,
                mess = "dữ liệu đã được hiển thị thành công",
                statusCode = 200
            };
        }
    }
}
