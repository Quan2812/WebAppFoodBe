using FOLYFOOD.Dto;
using FOLYFOOD.Dto.ProductDto;
using FOLYFOOD.Entitys;
using FOLYFOOD.Hellers.Pagination;

namespace FOLYFOOD.IService.IProduct
{
    public interface ProductInterface
    {
        public Task<RetunObject<Product>> CreateProduct(ProductDto product);

        public Task<RetunObject<Product>> updateProduct(int productId,  ProductDto product);

        public Task<IQueryable<Product>> getProducts(int? ProductTypeId, String? search = "", Double? priceFrom = 0, Double? priceTo = 0);
        
        public Task<RetunObject<Product>> updateStatus(int id);

        public Task<RetunObject<Product>> deleteProduct(int productId);

        public Task<IQueryable<Product>> GetLimitProductSeal();

        public Task<RetunObject<Product>> getDetailproduct(int productId);

        public Task<List<ProductResponse>> GetAllProductFrontend();

        public Task<Boolean> updateQuantity(int id, int quantity);
            

    }
}
