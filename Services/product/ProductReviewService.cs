using FOLYFOOD.Dto;
using FOLYFOOD.Dto.ProductDto;
using FOLYFOOD.Entitys;
using FOLYFOOD.Hellers.imageChecks;
using FOLYFOOD.IService.IProduct;
using FOLYFOOD.Services.order;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace FOLYFOOD.Services.product
{
    public class ProductReviewService : ProductReviewInterface
    {
        public readonly Context DBContext;
        private protected OrderServicer orderServicer;
        public ProductReviewService()
        {
            DBContext = new Context();
            orderServicer = new OrderServicer();
        }

        public async Task<RetunObject<ProductReview>> createReview(ProductReviewDto value)
        {
           User userReview = await DBContext.Users.SingleOrDefaultAsync(x=>x.UserId == value.UserId);
           Product product = await DBContext.Products.SingleOrDefaultAsync(x => x.ProductId == value.ProductId);
            try
            {
              
                if (value.ContentRated == "" || value.ProductId == null || value.UserId == null || value.PointEvaluation == null)
                {
                    throw new Exception("Thông tin gửi lên không đầy đủ");
                }
                //bool IsUserPurchasedProduct = await orderServicer.IsUserPurchasedProduct(value.UserId, value.ProductId.Value);
                //if (!IsUserPurchasedProduct)
                //{
                //    throw new Exception("sản phẩm không được phép bình luận do bạn chưa mua và trải nghiệm.");
                //}
                if (product == null) {
                    throw new Exception("sản phẩm đánh giá không tồn tại");
                }
               if(userReview == null)
                {
                    throw new Exception("người dùng đánh giá không tồn tại");
                }
             
            }
            catch (Exception ex)
            {
                return new RetunObject<ProductReview>()
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 401
                };
            }
            ProductReview productReviewCrate = new ProductReview()
            {
                ProductId = value.ProductId.Value,
                UserId = value.UserId.Value,
                ContentRated = value.ContentRated,
                PointEvaluation = value.PointEvaluation,
                Status = value.Status,
                ContentSeen = "",
            };
            await DBContext.ProductReviews.AddAsync(productReviewCrate);
            await DBContext.SaveChangesAsync();
             return new RetunObject<ProductReview>()
            {
                data = productReviewCrate,
                mess = "đã thêm đánh giá thành công",
                statusCode = 200
            };

        }

        public async Task<RetunObject<ProductReview>> deleteReview(int ProductReviewId)
        {

            ProductReview productReview = await DBContext.ProductReviews.SingleOrDefaultAsync(x => x.ProductReviewId == ProductReviewId);
            try
            {
                if (productReview == null)
                {
                    throw new Exception("Thông tin đánh giá không tồn tại");
                }
            }
            catch (Exception ex)
            {
                return new RetunObject<ProductReview>()
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 404
                };
            }
            DBContext.Remove(productReview);
            DBContext.SaveChangesAsync();

            return new RetunObject<ProductReview>()
            {
                data = productReview,
                mess = "đã xóa phản hồi đánh giá thành công",
                statusCode = 200
            };
        }

        public async Task<IQueryable<ProductReview>> getProductReview()
        {
            IQueryable<ProductReview> productReviews = DBContext.ProductReviews.AsNoTracking().AsQueryable();
            return productReviews;
        }

        public async Task<IQueryable<ProductReview>> getReviewForProduct(int productId)
        {
            IQueryable<ProductReview> productReviews = DBContext.ProductReviews.Include(x=>x.User).ThenInclude(x=>x.Account).Where(x => x.ProductId == productId && x.Status == 1).OrderByDescending(x=>x.ProductReviewId).AsNoTracking().AsQueryable();
            return productReviews;

        }

        public async Task<RetunObject<ProductReview>> replyReview(int ProductReviewId, string mess)
        {
            ProductReview productReview = await DBContext.ProductReviews.SingleOrDefaultAsync(x=>x.ProductReviewId == ProductReviewId);
            try
            {
                if (productReview == null)
                {
                    throw new Exception("Thông tin đánh giá không tồn tại");
                }
                if(mess == "")
                {
                    throw new Exception("Nội dung đánh giá không tồn tại");
                }

            }
            catch (Exception ex)
            {
                return new RetunObject<ProductReview>()
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 401
                };
            }
            productReview.ContentSeen = mess;
            DBContext.Update(productReview);
            DBContext.SaveChanges();

            return new RetunObject<ProductReview>()
            {
                data = productReview,
                mess = "đã đánh phản hồi đánh giá thành công",
                statusCode = 200
            };
        }

        public Task<RetunObject<ProductReview>> updateReview(ProductReviewDto value)
        {
            throw new NotImplementedException();
        }

        public async Task<RetunObject<ProductReview>> updateReviewStatus(int idProductReview)
        {
            ProductReview productReview = await DBContext.ProductReviews.SingleOrDefaultAsync(x => x.ProductReviewId == idProductReview);
            try
            {
                if (productReview == null)
                {
                    throw new Exception("Thông tin đánh giá không tồn tại");
                }

            }
            catch (Exception ex)
            {
                return new RetunObject<ProductReview>()
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 401
                };
            }
 
            throw new NotImplementedException();
        }
        public async Task<RetunObject<ProductReview>> getDetailProductReview(int productReviewId)
        {
            ProductReview productReview = await DBContext.ProductReviews.Include(x=>x.Product).Include(x=>x.User).AsNoTracking().SingleOrDefaultAsync(x => x.ProductReviewId == productReviewId);
            try
            {
                if (productReview == null)
                {
                    throw new Exception("Thông tin đánh giá không tồn tại");
                }

            }
            catch (Exception ex)
            {
                return new RetunObject<ProductReview>()
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 404
                };
            }
            return new RetunObject<ProductReview>()
            {
                data = productReview,
                mess = "đã lấy được dữ liệu thành công",
                statusCode = 200
            };

        }
    }
}
