using FOLYFOOD.Dto;
using FOLYFOOD.Dto.ProductType;
using FOLYFOOD.Entitys;
using FOLYFOOD.Hellers;
using FOLYFOOD.Hellers.imageChecks;
using FOLYFOOD.IService.IProduct;
using FOLYFOOD.IService.ITypeProduct;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace FOLYFOOD.Services.typeProduct
{
    public class TypeProductService : ProductTypeInterface
    {
        public readonly Context DBContext;

        public TypeProductService()
        {
            DBContext = new Context();
        }
        public async Task<RetunObject<ProductType>> createProductType(ProductTypeDto productType)
        {
            try
            {
                if (string.IsNullOrEmpty(productType.NameProductType))
                {
                    throw new Exception("không nhập tên loại sản phẩm vào ");
                }
                bool checkImage = ImageChecker.IsImage(productType.ImageTypeProduct);

                if (!checkImage)
                {
                    throw new Exception("xử lý ảnh lỗi");
                }
            }
            catch (Exception ex)
            {
                return new RetunObject<ProductType>()
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 401
                };
            }

            string link = await uplloadFile.UploadFile(productType.ImageTypeProduct);
            ProductType typeProduct = new ProductType()
            {
                ImageTypeProduct = link,
                NameProductType = productType.NameProductType,
            };
            await DBContext.ProductTypes.AddAsync(typeProduct);
            await DBContext.SaveChangesAsync();
            return new RetunObject<ProductType>()
            {
                data = typeProduct,
                mess = "thêm dữ liệu thành công",
                statusCode = 201
            };

        }

        public async Task<RetunObject<ProductType>> DeleteproductType(int productTypeId)
        {
            var res = await DBContext.ProductTypes.Include(x => x.Products).SingleOrDefaultAsync(x => x.ProductTypeId == productTypeId);
            try
            {
                if (res == null)
                {
                    throw new Exception("khong ton tai doi tuong can sua");

                }
                if (res.Products.Count() > 0)
                {
                    throw new Exception("sản phẩm của loại sản phẩm này vẫn còn");
                }
            }
            catch (Exception ex)
            {
                return new RetunObject<ProductType>()
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 400
                };
            }
            res.Products = null;
            await uplloadFile.DeleteFile(res.ImageTypeProduct);
            DBContext.ProductTypes.Remove(res);
            DBContext.SaveChanges();
            return new RetunObject<ProductType>()
            {
                data = res,
                mess = "xóa thành công",
                statusCode = 200
            };
        }

        public async Task<IQueryable<ProductType>> getProductType()
        {
            return DBContext.ProductTypes.Include(x => x.Products).AsNoTracking();
        }
        public async Task<IQueryable<dynamic>> getProductTypeFrontend()
        {
            return DBContext.ProductTypes
    .Where(x => x.Products.Count() > 0)
    .Select(x => new
    {
        ProductTypeId = x.ProductTypeId,
        NameProductType = x.NameProductType,
        ImageTypeProduct = x.ImageTypeProduct,
        CreatedAt = x.CreatedAt,
        UpdatedAt = x.UpdatedAt,
        Key = Guid.NewGuid()
    }).AsNoTracking();
        }
        public async Task<RetunObject<ProductType>> getTypeProductDetail(int productTypeId)
        {
            var res = await DBContext.ProductTypes.SingleOrDefaultAsync(x => x.ProductTypeId == productTypeId);
            try
            {
                if (res == null) { throw new Exception("không tồn tại loại sản phẩm trong dữ liệu"); }

            }
            catch (Exception ex)
            {
                return new RetunObject<ProductType>()
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 400
                };
            }
            return new RetunObject<ProductType>()
            {
                data = res,
                mess = "đã lấy được dữ liệu",
                statusCode = 200
            };
        }

        public async Task<RetunObject<ProductType>> updateProductType(int id, ProductTypeDto productType)
        {
            var res = DBContext.ProductTypes.SingleOrDefault(x => x.ProductTypeId == id);
            try
            {
                if (res == null)
                {
                    throw new Exception("khong ton tai doi tuong can sua");
                }
                if (string.IsNullOrEmpty(productType.NameProductType))
                {
                    throw new Exception("không nhập tên loại sản phẩm vào ");
                }
                if (productType.ImageTypeProduct != null)
                {
                    bool checkImage = ImageChecker.IsImage(productType.ImageTypeProduct);
                    if (!checkImage)
                    {
                        throw new Exception("xử lý ảnh lỗi");
                    }
                }

            }
            catch (Exception ex)
            {
                return new RetunObject<ProductType>()
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 401
                };
            }
            res.NameProductType = productType.NameProductType;
            if (productType.ImageTypeProduct != null)
            {
                await uplloadFile.DeleteFile(res.ImageTypeProduct);
                string link = await uplloadFile.UploadFile(productType.ImageTypeProduct);
                res.ImageTypeProduct = link;
            }

            DBContext.ProductTypes.Update(res);
            DBContext.SaveChanges();
            return new RetunObject<ProductType>()
            {
                data = res,
                mess = "sửa dữ liệu thành công",
                statusCode = 201
            };
        }

        public Task<RetunObject<ProductType>> updateStatus(int id, int codeStatus)
        {
            throw new NotImplementedException();
        }
    }
}
