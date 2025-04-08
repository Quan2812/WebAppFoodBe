using FOLYFOOD.Dto.ProductDto;
using FOLYFOOD.Dto;
using FOLYFOOD.Entitys;
using FOLYFOOD.Dto.ProductDto.imageProductDto;

namespace FOLYFOOD.IService.IProduct.IImageProduct
{
    public interface ImageProductInterface
    {
        public Task<RetunObject<IQueryable<ProductImage>>> CreateListImage(List<IFormFile> images, int idProduct);
        public Task<RetunObject<ProductImage>> UpdateImage(ImageProductDto product);
        public Task<RetunObject<ProductImage>> DeleteListImage(int id);
        public Task<IQueryable<ProductImage>> getListImageByIdProduct(int productId);
    }
}
