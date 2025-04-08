using FOLYFOOD.Dto;
using FOLYFOOD.Dto.ProductDto.imageProductDto;
using FOLYFOOD.Entitys;
using FOLYFOOD.Hellers;
using FOLYFOOD.Hellers.imageChecks;
using FOLYFOOD.IService.IProduct.IImageProduct;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;

namespace FOLYFOOD.Services.product.ImageProduct
{
    public class ImageProductService : ImageProductInterface
    {
        public readonly Context DBContext;

        public ImageProductService()
        {
            DBContext = new Context();
        }
        public async Task<RetunObject<IQueryable<ProductImage>>> CreateListImage(List<IFormFile> images, int idProduct)
        {
            Product product =  await DBContext.Products.FirstOrDefaultAsync(x=>x.ProductId == idProduct);
            try
            {
                if(product == null)
                {
                    throw new Exception("Sản phẩm không tồn tại");
                }
                if(DBContext.ProductImages.Where(x=>x.ProductId == idProduct).Count() > 0)
                {
                    throw new Exception("đã tồn tại sản phẩm trước đó");
                }
                if(images.Count == 0)
                {
                    throw new Exception("không tồn tại ảnh để thêm");
                }
                if(images.Count > 3)
                {
                    throw new Exception("bạn đã gửi quá nhiều ảnh không được quá 3 ảnh ");
                }
                foreach(var image in images)
                {
                    if (!ImageChecker.IsImage(image))
                    {
                        throw new Exception("có lỗi trong quá trình sử lý ảnh");
                    }
                }

            }
            catch (Exception ex)
            {
                return new RetunObject<IQueryable<ProductImage>>()
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 401
                };
            }
            List<ProductImage> productImageCrate = new List<ProductImage>();
            int index = 0;
                foreach (IFormFile image in images)
                {
                index++;
                ProductImage productImage = new ProductImage();
                string url = await uplloadFile.UploadFile(image);
                productImage.ProductId = idProduct;
                productImage.ImageProduct = url;
                productImage.Title =  "đây là bức ảnh " + " của sản phẩm " + product.NameProduct;
                productImage.Status = 1;
                productImageCrate.Add(productImage);
            }
            DBContext.ProductImages.AddRangeAsync(productImageCrate);
            DBContext.SaveChanges();

            return new RetunObject<IQueryable<ProductImage>>()
            {
                data = productImageCrate.AsQueryable(),
                mess = "thêm danh sách ảnh thành công",
                statusCode = 201
            };

        }

        public async Task<RetunObject<ProductImage>> DeleteListImage(int id)
        {
           var imageProduct = DBContext.ProductImages.FirstOrDefault(x=>x.ProductImageId == id);
            if (imageProduct != null)
            {
                return new RetunObject<ProductImage>()
                {
                    data = null,
                    mess = "ảnh không tồn tại để xóa",
                    statusCode = 401
                };
            }
            await uplloadFile.DeleteFile(imageProduct.ImageProduct);

            DBContext.Remove(imageProduct);
            DBContext.SaveChanges();
            return new RetunObject<ProductImage>()
            {
                data = imageProduct,
                mess = "xóa ảnh thành công",
                statusCode = 200
            };
        }

        public Task<IQueryable<ProductImage>> getListImageByIdProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public async Task<RetunObject<ProductImage>> UpdateImage(ImageProductDto product)
        {
            var imageProduct = await DBContext.ProductImages.FirstOrDefaultAsync(x => x.ProductImageId == product.ProductImageId);
            try
            {
                if (imageProduct == null)
                {
                    throw new Exception("Sản phẩm không tồn tại");
                }

                if (!ImageChecker.IsImage(product.ImageProduct))
                {
                    throw new Exception("có lỗi trong quá trình sử lý ảnh");
                }

            }
            catch (Exception ex)
            {
                return new RetunObject<ProductImage>()
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 401
                };
            }
            string url = await  uplloadFile.UpdateFile(imageProduct.ImageProduct, product.ImageProduct);
            imageProduct.ImageProduct = url;
            DBContext.Update(imageProduct);
            DBContext.SaveChangesAsync();   
            return new RetunObject<ProductImage>()
            {
                data = imageProduct,
                mess = "đã thay đổi ảnh thành công",
                statusCode = 401
            };
        }
    
}
}
