using FOLYFOOD.Dto;
using FOLYFOOD.Dto.ProductType;
using FOLYFOOD.Entitys;

namespace FOLYFOOD.IService.ITypeProduct
{
    public interface ProductTypeInterface
    {
        public Task<RetunObject<ProductType>> createProductType(ProductTypeDto productType);
        public Task<IQueryable<ProductType>> getProductType();
        public Task<RetunObject<ProductType>> getTypeProductDetail(int productTypeId);
        public Task<RetunObject<ProductType>> updateStatus(int id, int codeStatus);
        public Task<RetunObject<ProductType>> updateProductType(int id,ProductTypeDto productType);
        public Task<RetunObject<ProductType>> DeleteproductType(int productTypeId);


    }
}
