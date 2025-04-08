using CloudinaryDotNet.Actions;
using FOLYFOOD.Dto;
using FOLYFOOD.Dto.UserDto;
using FOLYFOOD.Entitys;
using FOLYFOOD.Hellers;
using FOLYFOOD.Hellers.imageChecks;
using FOLYFOOD.Hellers.validate;
using FOLYFOOD.IService;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using BCryptNet = BCrypt.Net.BCrypt;

namespace FOLYFOOD.Services
{
    public class UserService : IUserService
    {
        private readonly Context DbContext;

        public UserService()
        {
            DbContext = new Context();
        }

        public async Task<RetunObject<Account>> DeleteUser(int id)
        {
            Account userUpdate = await DbContext.Accounts.FirstOrDefaultAsync(x => x.AccountId == id);
            try
            {
                if (userUpdate == null)
                {
                    throw new Exception("thông tin người dùng không tồn tại");
                }
                int imageSize = 2 * 1024 * 1024; // tương ứng với 2mb
            }
            catch (Exception ex)
            {
                return new RetunObject<Account>
                {
                    data =null,
                    mess = ex.Message,
                    statusCode = 400,
                };

            }
            var userInfo = DbContext.Users.FirstOrDefault(x => x.AccountId == id);
            DbContext.Users.Remove(userInfo);
            await DbContext.SaveChangesAsync();
            if (!userUpdate.Avartar.Contains("https://media.istockphoto.com/id/1300845620/vector/user-icon-flat-isolated-on-white-background-user-symbol-vector-illustration.jpg?s=612x612&w=0&k=20&c=yBeyba0hUkh14_jgv1OKqIH0CCSWU_4ckRkAoy2p73o=")){
                await uplloadFile.DeleteFile(userUpdate.Avartar);
            }
            DbContext.Accounts.Remove(userUpdate);
            await DbContext.SaveChangesAsync();
            return new RetunObject<Account>
            {
                data = userUpdate,
                mess = "đã xóa thành công user",
                statusCode = 200,
            };
        }

        public async Task<IQueryable<Account>> getListUser(string search,int? roleId)
        {
            // lấy dữ liệu user nha 
            var listUser = DbContext.Accounts.AsNoTracking().Include(x => x.User).Include(x=>x.Decentralization).OrderByDescending(x=>x.AccountId).Where(x=>x.UserName.ToLower().Contains(search.ToLower()));
            if (roleId.HasValue)
            {
                listUser = listUser.Where(x => x.DecentralizationId == roleId).AsNoTracking().AsQueryable();
            }
            return listUser;
        }

        public async Task<Account> getOneUser(int id)
        {
            var user = await DbContext.Accounts.Include(x=>x.User).FirstOrDefaultAsync(x => x.AccountId == id);
            return user;
        }
        public async Task<RetunObject<Account>> changeStatus(int id)
        {
            Account userUpdate = await DbContext.Accounts.FirstOrDefaultAsync(x => x.AccountId == id);
            try
            {
                if (userUpdate == null)
                {
                    throw new Exception("thông tin người dùng không tồn tại");
                }
            }
            catch (Exception ex)
            {
                return new RetunObject<Account>
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 400,
                };

            }
            userUpdate.Status = userUpdate.Status == 1 ? 0 : 1;
            DbContext.Accounts.Update(userUpdate);
            await DbContext.SaveChangesAsync();
            return new RetunObject<Account>
            {
                data = userUpdate,
                mess = "đã thay đổi thành công trạng thái",
                statusCode = 200,
            };
        }
        public async Task<Account> Register(RegisterRequets data)
        {
            if (data.UserName == "" || data.DecentralizationId == null || data.Password == "" || data.Status == null)
            {
                return null;
            }
            if (DbContext.Accounts.Any(x => x.UserName == data.UserName || x.Email == data.Email))
            {
                return null;
            }

            var avatarFile = data.Avatar;
            string imageUrl = await uplloadFile.UploadFile(avatarFile);
            // Mã hóa mật khẩu
            string hashedPassword = BCryptNet.HashPassword(data.Password);

            ////// Kiểm tra mật khẩu
            ////bool isPasswordCorrect = BCryptNet.Verify(password, hashedPassword);
            var res = new Account()
            {
                Password = hashedPassword,
                Avartar = imageUrl,
                Status = 1,
                DecentralizationId = 3,
                UserName = data.UserName,
                Email = data.Email,
            };

            await DbContext.Accounts.AddAsync(res);
            await DbContext.SaveChangesAsync();
            var user = new User()
            {
                Email = data.Email,
                UserName = "",
                Phone = "",
                Address = "",
                AccountId = res.AccountId,

            };
            await DbContext.Users.AddAsync(user);
            await DbContext.SaveChangesAsync();

            var carts = new Carts()
            {
                UserId = user.UserId,
            };
            await DbContext.Carts.AddAsync(carts);
            await DbContext.SaveChangesAsync();
            return res;
        } 
        public async Task<RetunObject<Account>> ChangeRole(int id)
        {
            Account user = await DbContext.Accounts.FirstOrDefaultAsync(x => x.AccountId == id);
            try
            {

                if (user == null)
                {
                    throw new Exception("thông tin người dùng không tồn tại");
                }
              
            }
            catch (Exception ex)
            {
              return  new RetunObject<Account>
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 400,
                };
                
            }
            user.DecentralizationId = user.DecentralizationId == 1 ? 3 : 1;
            DbContext.Accounts.Update(user);
            DbContext.SaveChanges();
            return new RetunObject<Account>
            {
                data = user,
                mess = "ảnh gửi về",
                statusCode = 204,
            };

        }
        public async Task<RetunObject<string>> updateImageAvatar(IFormFile file,int id ,string accountId,string role)
        {

            Account userUpdate = await DbContext.Accounts.FirstOrDefaultAsync(x => x.AccountId == id);
            try
            {
                if (role != "admin")
                {
                    if (int.Parse(accountId) != userUpdate.AccountId)
                    {
                        throw new Exception("bạn không có quyền sửa tài khoảng của người khác");
                    }
                }
                if (userUpdate == null)
                {
                    throw new Exception("thông tin người dùng không tồn tại");
                }
                int imageSize = 2 * 1024 * 1024; // tương ứng với 2mb
                bool checkImage = ImageChecker.IsImage(file, imageSize);

                if (!checkImage)
                {
                    throw new Exception("xử lý ảnh lỗi");
                }
            }
            catch (Exception ex)
            {
              return  new RetunObject<string>
                {
                    data = ex.Message,
                    mess = ex.Message,
                    statusCode = 400,
                };
                
            }
            if(DbContext.Accounts.FirstOrDefault(x=>x.AccountId == id).Avartar != "https://media.istockphoto.com/id/1300845620/vector/user-icon-flat-isolated-on-white-background-user-symbol-vector-illustration.jpg?s=612x612&w=0&k=20&c=yBeyba0hUkh14_jgv1OKqIH0CCSWU_4ckRkAoy2p73o=")
            {
                await uplloadFile.DeleteFile(userUpdate.Avartar);
            }
            string link = await uplloadFile.UploadFile(file);
            userUpdate.Avartar = link;
            DbContext.Accounts.Update(userUpdate);
            DbContext.SaveChanges();
            return new RetunObject<string>
            {
                data = link,
                mess = "ảnh gửi về",
                statusCode = 204,
            }; ;
        }
        public async Task<RetunObject<Account>> updateOneAccount(UserUpdateClient account, int id, string accountId, string role)
        {
          
            Account userUpdate = await DbContext.Accounts.FirstOrDefaultAsync(x => x.AccountId == id);
            User detailUser = await DbContext.Users.FirstOrDefaultAsync(y => y.AccountId == id);
            try
            {
                if (role != "admin")
                {
                    if(int.Parse(accountId) != userUpdate.AccountId)
                    {
                        throw new Exception("bạn không có quyền sửa tài khoảng của người khác");
                    }
                }
                if (userUpdate == null)
                {
                    throw new Exception("thông tin người dùng không tồn tại");
                }
                if (string.IsNullOrEmpty(account.UserName) || string.IsNullOrEmpty(account.Address) || string.IsNullOrEmpty(account.Phone) || string.IsNullOrEmpty(account.Email))
                {
                    throw new Exception("các thông tin nhập vào chưa đầy đủ");
                }
                if (!ValidateValue.IsValidEmail(account.Email))
                {
                    throw new Exception("email nhập vào không hợp lệ");
                }
                if (!ValidateValue.IsValidPhoneNumber(account.Phone))
                {
                    throw new Exception("phone nhập vào không hợp lệ");
                }
            }
            catch (Exception ex)
            {
                return new RetunObject<Account>
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 400,
                };
            }
            detailUser.Address = account.Address;
            detailUser.Phone = account.Phone;
            detailUser.Email = account.Email;
            detailUser.UserName = account.UserName;

            DbContext.Users.Update(detailUser);
            DbContext.SaveChanges();
            return new RetunObject<Account>
            {
                data = await DbContext.Accounts.Include(x => x.User).FirstOrDefaultAsync(x => x.AccountId == id),
                mess = "thêm thành công",
                statusCode = 204,
            };


        }
    }
}
