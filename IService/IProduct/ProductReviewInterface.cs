using FOLYFOOD.Dto;
using FOLYFOOD.Dto.ProductDto;
using FOLYFOOD.Entitys;

namespace FOLYFOOD.IService.IProduct
{
    public interface ProductReviewInterface
    {
        public Task<RetunObject<ProductReview>> createReview(ProductReviewDto value);
        public Task<RetunObject<ProductReview>> replyReview(int ProductReviewId, string mess);

        public Task<RetunObject<ProductReview>> updateReview(ProductReviewDto value);

        public Task<RetunObject<ProductReview>> deleteReview(int ProductReviewId);

        public Task<IQueryable<ProductReview>> getReviewForProduct(int productId);

        public Task<IQueryable<ProductReview>> getProductReview();
    }
}
