using FOLYFOOD.Dto;
using FOLYFOOD.Dto.NewsDto;
using FOLYFOOD.Entitys;
using FOLYFOOD.Hellers.imageChecks;
using FOLYFOOD.Hellers;
using FOLYFOOD.Services.product;
using Microsoft.EntityFrameworkCore;

namespace FOLYFOOD.Services.News
{
    public class NewsServicer
    {
        public readonly Context DBContext;

        public NewsServicer()
        {
            DBContext = new Context();
        }

        public async Task<RetunObject<FOLYFOOD.Entitys.News>> GetDetailNews(int NewsId)
        {
            var news = DBContext.News.Include(x=>x.Account).ThenInclude(x=>x.User).SingleOrDefault(x=>x.NewsId == NewsId);
            try
            {
                if (news == null)
                {
                    throw new Exception("Không tồn tại bài viết này");
                }
            }catch (Exception ex)
            {
                return new RetunObject<FOLYFOOD.Entitys.News>()
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 404
                };
            }
            return new RetunObject<FOLYFOOD.Entitys.News>()
            {
                data = news,
                mess = "đã lấy được dữ liệu",
                statusCode = 200
            };
        }

        public async Task<RetunObject<FOLYFOOD.Entitys.News>> CrateNews(NewsRequest newsRequest)
        {
           Account account =  DBContext.Accounts.SingleOrDefault(x => x.AccountId == newsRequest.AccountId);
            try
            {
                if(account == null)
                {
                    throw new Exception("Không tồn tại tài khoảng. ");
                }
                if (account.DecentralizationId != 1)
                {
                    throw new Exception("Tài khoảng của bạn không có quyền được thêm Bài viết. ");
                }
                if(newsRequest.ShortDescription == null || newsRequest.Content == null || newsRequest.Title == null) {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin các trường");
                }
                bool checkImage = ImageChecker.IsImage(newsRequest.Image);

                if (!checkImage)
                {
                    throw new Exception("xử lý ảnh lỗi");
                }
            }
            catch (Exception ex)
            {
                return new RetunObject<FOLYFOOD.Entitys.News>()
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 404
                };
            }

            string link = await uplloadFile.UploadFile(newsRequest.Image,true);
            FOLYFOOD.Entitys.News newCreate = new FOLYFOOD.Entitys.News()
            {
                AccountId = account.AccountId,
                Title = newsRequest.Title,
                Content = newsRequest.Content,
                Image = link,
                ShortDescription = newsRequest.ShortDescription,
                IsShow = true

            };
            await DBContext.News.AddAsync(newCreate);
            await DBContext.SaveChangesAsync();
            return new RetunObject<FOLYFOOD.Entitys.News>()
            {
                data = newCreate,
                mess = "thêm dữ liệu thành công",
                statusCode = 201
            };
        }

        public async Task<RetunObject<FOLYFOOD.Entitys.News>> UpdateNews(NewsRequest newsRequest)
        {
            Account account = DBContext.Accounts.SingleOrDefault(x => x.AccountId == newsRequest.AccountId);
            FOLYFOOD.Entitys.News news = DBContext.News.SingleOrDefault(x => x.NewsId == newsRequest.NewsId);
            try
            {
                if(news != null)
                {
                    throw new Exception("Bài viết không tồn tại");
                }
                if (account == null)
                {
                    throw new Exception("Không tồn tại tài khoảng. ");
                }
                if (account.DecentralizationId != 1)
                {
                    throw new Exception("Tài khoảng của bạn không có quyền được sửa bài viết. ");
                }
                if (newsRequest.ShortDescription == null || newsRequest.Content == null || newsRequest.Title == null)
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin các trường");
                }
                if(newsRequest.Image !=  null)
                {
                    bool checkImage = ImageChecker.IsImage(newsRequest.Image);

                    if (!checkImage)
                    {
                        throw new Exception("xử lý ảnh lỗi");
                    }
                }
            }
            catch (Exception ex)
            {
                return new RetunObject<FOLYFOOD.Entitys.News>()
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 404
                };
            }
            string link = news.Image;
            if (newsRequest.Image != null)
            {
                link = await uplloadFile.UpdateFile(link, newsRequest.Image);
            }

            news.AccountId = account.AccountId;
            news.Title = newsRequest.Title;
            news.Content = newsRequest.Content;
            news.Image = link;
            news.ShortDescription = newsRequest.ShortDescription;
            news.IsShow = newsRequest.IsShow.HasValue;

            
                  DBContext.News.Update(news);
            await DBContext.SaveChangesAsync();
            return new RetunObject<FOLYFOOD.Entitys.News>()
            {
                data = news,
                mess = "sửa dữ liệu thành công",
                statusCode = 201
            };
        }

        public async Task<IQueryable<FOLYFOOD.Entitys.News>> GetNews()
        {
            return DBContext.News
                .Include(x => x.Account)
                .ThenInclude(x => x.User)
                .AsNoTracking()
                .Select(n => new FOLYFOOD.Entitys.News
                {
                    NewsId = n.NewsId,
                    Title = n.Title,
                    ShortDescription = n.ShortDescription,
                    Image = n.Image,
                    IsShow = n.IsShow,
                    CreatedAt = n.CreatedAt,
                    UpdatedAt = n.UpdatedAt,
                    AccountId = n.AccountId,
                    Account = n.Account // Lưu ý: Để lấy thông tin tài khoản liên kết, bạn có thể chỉ lấy AccountId hoặc lấy cả đối tượng Account tùy ý.
                })
                .AsQueryable();
        }

        public async Task<RetunObject<FOLYFOOD.Entitys.News>> DeleteNews(int newsId)
        {
            FOLYFOOD.Entitys.News news = DBContext.News.SingleOrDefault(x => x.NewsId == newsId);
            try { 

                if (news == null)
                {
                    throw new Exception("không tìm thấy sản phẩm cần tìm ");
                }
            }
            catch (Exception ex)
            {
                return new RetunObject<FOLYFOOD.Entitys.News>()
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 404
                };
            }
            await uplloadFile.DeleteFile(news.Image);
            DBContext.News.Remove(news);
            await DBContext.SaveChangesAsync();
            return new RetunObject<FOLYFOOD.Entitys.News>()
            {
                data = news,
                mess = "đã xóa thành công",
                statusCode = 200
            };
        }
        
    

    }
}
