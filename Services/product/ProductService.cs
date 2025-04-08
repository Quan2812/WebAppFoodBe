using FOLYFOOD.Dto;
using FOLYFOOD.Dto.ProductDto;
using FOLYFOOD.Entitys;
using FOLYFOOD.Hellers;
using FOLYFOOD.Hellers.imageChecks;
using FOLYFOOD.IService.IProduct;
using Microsoft.EntityFrameworkCore;

namespace FOLYFOOD.Services.product
{
    public class ProductService : ProductInterface
    {
        public readonly Context DBContext;

        public ProductService()
        {
            DBContext = new Context();
        }
        public async Task<RetunObject<Product>> CreateProduct(ProductDto product)
        {
            ProductType checkTypeProduct = null;
            try
            {
                if (!product.ProductTypeId.HasValue || product.Price == null || product.Discount == null || product.Status == null || string.IsNullOrEmpty(product.NameProduct) || string.IsNullOrEmpty(product.shortDescription) || string.IsNullOrEmpty(product.fullDescription) || product.AvartarImageProduct == null || product.Quantity < 0)
                {
                    throw new Exception("dữ liệu sản phẩm chuyền lên không đầy đủ");
                }
                if (!ImageChecker.IsImage(product.AvartarImageProduct))
                {
                    throw new Exception("có lỗi trong quá trình sử lý ảnh");
                }
                checkTypeProduct = await DBContext.ProductTypes.SingleOrDefaultAsync(x => x.ProductTypeId == product.ProductTypeId);
                if (checkTypeProduct == null)
                {
                    throw new Exception("loại sản phẩm thêm vào không tồn tại");
                }
                if (product.Price < 0)
                {
                    throw new Exception("giá không được là số âm");

                }
                if (product.Discount < 0 || product.Discount > 100)
                {
                    throw new Exception("giảm giá là % không được âm hoặc lớn hơn 100");
                }

            }
            catch (Exception ex)
            {
                return new RetunObject<Product>()
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 401
                };
            }
            string link = await uplloadFile.UploadFile(product.AvartarImageProduct);
            Product productCreate = new Product()
            {
                ProductTypeId = product.ProductTypeId.Value,
                AvartarImageProduct = link,
                NameProduct = product.NameProduct,
                Price = product.Price,
                Quantity = product.Quantity,
                Discount = product.Discount.Value,
                fullDescription = product.fullDescription,
                shortDescription = product.shortDescription,
                Status = product.Status.Value,
                Title = "",

            };
            await DBContext.Products.AddAsync(productCreate);
            await DBContext.SaveChangesAsync();
            return new RetunObject<Product>()
            {
                data = productCreate,
                mess = "thêm thành công sản phẩm",
                statusCode = 201
            };
        }

        public async Task<RetunObject<Product>> deleteProduct(int productId)
        {
            Product checkProduct = null;
            try
            {
                checkProduct = await DBContext.Products.FirstOrDefaultAsync(x => x.ProductId == productId);
                if (checkProduct == null)
                {
                    throw new Exception("không tìm thấy sản phẩm cần tìm ");
                }
                if(DBContext.OrderDetails.Where(x=>x.ProductId == productId).Count() > 0)
                {
                    throw new Exception("Không thể xóa tác nhân đã phụ thuộc");
                }
                if(DBContext.ProductReviews.Where(x => x.ProductId == productId).Count() > 0)
                {
                    throw new Exception("Không thể xóa tác nhân đã phụ thuộc");
                } 
            }
            catch (Exception ex)
            {
                return new RetunObject<Product>()
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 404
                };
            }
            await uplloadFile.DeleteFile(checkProduct.AvartarImageProduct);
            var listImage = DBContext.ProductImages.Where(x => x.ProductId == productId).ToList();
            if (listImage.Count > 0)
            {
                DBContext.ProductImages.RemoveRange(listImage);
                await DBContext.SaveChangesAsync();
            }
            DBContext.Products.Remove(checkProduct);
            await DBContext.SaveChangesAsync();
            return new RetunObject<Product>()
            {
                data = checkProduct,
                mess = "đã xóa thành công",
                statusCode = 200
            };
        }

        public async Task<RetunObject<Product>> increaseViews(int productId)
        {
            Product checkProduct = null;
            try
            {
                checkProduct = await DBContext.Products.Include(x => x.ProductType).SingleOrDefaultAsync(x => x.ProductId == productId);
                if (checkProduct == null)
                {
                    throw new Exception("sản phẩm cần tăng lượt xem không tồn tại");
                }
            }
            catch (Exception ex)
            {
                return new RetunObject<Product>()
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 401
                };
            }
            checkProduct.number_of_views += 1;
            DBContext.Products.Update(checkProduct);
            DBContext.SaveChanges();
            return new RetunObject<Product>()
            {
                data = checkProduct,
                mess = "lấy sản phẩm thành công",
                statusCode = 200
            };

        }

        public async Task<RetunObject<Product>> getDetailproduct(int productId)
        {
            Product checkProduct = null;
            try
            {
                checkProduct = await DBContext.Products.Include(x => x.ProductType).SingleOrDefaultAsync(x => x.ProductId == productId);
                if (checkProduct == null)
                {
                    throw new Exception("sản phẩm cần lấy không tồn tại");
                }
            }
            catch (Exception ex)
            {
                return new RetunObject<Product>()
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 401
                };
            }
            return new RetunObject<Product>()
            {
                data = checkProduct,
                mess = "lấy sản phẩm thành công",
                statusCode = 200
            };
        }
        public async Task<IQueryable<Product>> getProducts(int? ProductTypeId, String? search = "", Double? priceFrom = 0, Double? priceTo = 0)
        {
            var data = DBContext.Products.Include(x => x.ProductType).AsQueryable();
            if (!string.IsNullOrEmpty(search))
            {
                data = data.Where(x => x.NameProduct.ToLower().Contains(search));
            }
            if (priceFrom != null && priceTo != null)
            {
                data = data.Where(x => x.Price >= priceFrom && x.Price <= priceTo);
            }
            if (ProductTypeId.HasValue)
            {
                data = data.Where(x => x.ProductTypeId == ProductTypeId.Value);
            }

            // Lấy dữ liệu về số lượng sản phẩm đã được đặt hàng
            var productQuantities = await DBContext.OrderDetails
                .Where(od => !DBContext.Orders.Any(o => o.OrderStatusId != 5 && o.OrderId == od.OrderId))
                .GroupBy(od => od.ProductId)
                .Select(grouped => new
                {
                    ProductId = grouped.Key,
                    Quantity = grouped.Sum(od => od.Quantity)
                })
                .ToListAsync();

            // Gán giá trị QuantityOrder cho từng sản phẩm trong data
            foreach (var product in data)
            {
                var quantityOrder = productQuantities.FirstOrDefault(pq => pq.ProductId == product.ProductId);
                if (quantityOrder != null)
                {
                    product.QuantityOrder = quantityOrder.Quantity;
                }
                else
                {
                    product.QuantityOrder = 0;
                }

                product.ProductType.Products = null;
            }

            return data.OrderByDescending(x => x.Status).ThenByDescending(x => x.number_of_views).ThenByDescending(x => x.ProductId);
        }


        public async Task<RetunObject<Product>> updateProduct(int productId, ProductDto product)
        {
            ProductType checkTypeProduct = null;
            Product checkProduct = null;
            try
            {
                if (!product.ProductTypeId.HasValue || product.Price == null || product.Discount == null || product.Status == null || string.IsNullOrEmpty(product.NameProduct) || product.Quantity < 0)
                {
                    throw new Exception("dữ liệu sản phẩm chuyền lên không đầy đủ");
                }
                if (product.AvartarImageProduct != null)
                {
                    if (!ImageChecker.IsImage(product.AvartarImageProduct))
                    {
                        throw new Exception("có lỗi trong quá trình sử lý ảnh");
                    }
                }
                if (product.Price < 0)
                {
                    throw new Exception("giá không được là số âm");

                }
                if (product.Discount < 0 || product.Discount > 100)
                {
                    throw new Exception("giảm giá là % không được âm hoặc lớn hơn 100");
                }

                checkTypeProduct = await DBContext.ProductTypes.SingleOrDefaultAsync(x => x.ProductTypeId == product.ProductTypeId);
                if (checkTypeProduct == null)
                {
                    throw new Exception("loại sản phẩm  không tồn tại");
                }
                checkProduct = await DBContext.Products.SingleOrDefaultAsync(x => x.ProductId == productId);
                if (checkProduct == null)
                {
                    throw new Exception("sản phẩm không tồn tại");
                }
            }
            catch (Exception ex)
            {
                return new RetunObject<Product>()
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 401
                };
            }
            string link = checkProduct.AvartarImageProduct;
            if (product.AvartarImageProduct != null)
            {
                link = await uplloadFile.UpdateFile(link, product.AvartarImageProduct);
            }
            checkProduct.ProductTypeId = product.ProductTypeId.Value;
            checkProduct.AvartarImageProduct = link;
            checkProduct.NameProduct = product.NameProduct;
            checkProduct.Price = product.Price;
            checkProduct.Quantity = product.Quantity;
            checkProduct.Discount = product.Discount.Value;
            checkProduct.Status = product.Status.Value;
            checkProduct.fullDescription = string.IsNullOrEmpty(product.fullDescription) ? checkProduct.fullDescription : product.fullDescription;
            checkProduct.shortDescription = string.IsNullOrEmpty(product.shortDescription) ? checkProduct.shortDescription : product.shortDescription;
            checkProduct.UpdatedAt = DateTime.Now;
            DBContext.Products.Update(checkProduct);
            await DBContext.SaveChangesAsync();
            return new RetunObject<Product>()
            {
                data = checkProduct,
                mess = "sửa sản phẩm thành công",
                statusCode = 200
            };
        }

        public async Task<RetunObject<Product>> updateStatus(int id)
        {
            Product checkProduct = null;
            try
            {
                checkProduct = await DBContext.Products.Include(x => x.ProductType).SingleOrDefaultAsync(x => x.ProductId == id);
                if (checkProduct == null)
                {
                    throw new Exception("sản phẩm cần lấy không tồn tại");
                }
            }
            catch (Exception ex)
            {
                return new RetunObject<Product>()
                {
                    data = null,
                    mess = ex.Message,
                    statusCode = 401
                };
            }
            checkProduct.Status = checkProduct.Status == 1 ? 0 : 1;
            checkProduct.UpdatedAt = DateTime.Now;
            DBContext.Products.Update(checkProduct);
            DBContext.SaveChanges();
            return new RetunObject<Product>()
            {
                data = checkProduct,
                mess = "cập nhật trạng thái thành công",
                statusCode = 200
            };
            throw new NotImplementedException();
        }

        public async Task<IQueryable<Product>> GetLimitProductSeal()
        {
            var data = DBContext.Products.Include(x => x.ProductType).Where(x => x.Discount > 0).OrderByDescending(x => x.CreatedAt).Take(8).AsQueryable();
            return data;
        }

        public async Task<List<ProductResponse>> GetAllProductFrontend()
        {
            List<ProductResponse> dataRes = new List<ProductResponse>();

            var data = DBContext.Products
                .Include(x => x.ProductType)
                .Include(x => x.ProductImages)
                .Where(x => x.Status == 1)
                .OrderByDescending(x => x.number_of_views)
                .ThenByDescending(x => x.ProductId)
                .ToList(); // Sử dụng ToList() thay vì AsQueryable()

            var productReviewData = DBContext.ProductReviews
                .Where(pr => data.Select(p => p.ProductId).Contains(pr.ProductId))
                .ToList(); // Lấy dữ liệu đánh giá sản phẩm trong một truy vấn duy nhất

            foreach (var item in data)
            {
                var dataOne = new ProductResponse();
                dataOne.tag.Add(item.ProductType.NameProductType.ToString());
                dataOne.image.Add(item.AvartarImageProduct);

                if (item.ProductImages.Count > 0)
                {
                    foreach (var image in item.ProductImages)
                    {
                        dataOne.image.Add(image.ImageProduct);
                    }
                }

                DateTime currentDate = DateTime.Today;
                DateTime availableDate = item.CreatedAt;

                TimeSpan difference = currentDate - availableDate;
                int daysDifference = difference.Days;
                dataOne.id = item.ProductId.ToString();
                dataOne.sku = item.ProductId.ToString() + "key" + new Random().Next(1, 199);
                dataOne.price = item.Price;
                dataOne.discount = item.Discount;

                var productReview = productReviewData.Where(pr => pr.ProductId == item.ProductId).ToList();
                dataOne.rating = 0;
                if (productReview.Count >  0)
                {
                        dataOne.rating = (int)(productReview.Average(x=>x.PointEvaluation)); // Sử dụng dữ liệu đánh giá sản phẩm đã lấy
                }
                dataOne.stock = item.Quantity;
                dataOne.name = item.NameProduct;
                dataOne.saleCount = item.Quantity;
                dataOne.category.Add("all");
                dataOne.category.Add(item.ProductType.NameProductType.ToString());
                dataOne.new_product = daysDifference <= 5;
                dataOne.fullDescription = string.IsNullOrEmpty(item.fullDescription) ? "dữ liệu chưa được cập nhật" : item.fullDescription;
                dataOne.shortDescription = string.IsNullOrEmpty(item.shortDescription) ? "dữ liệu chưa được cập nhật" : item.shortDescription;
                dataRes.Add(dataOne);
            }

            return dataRes;
        }


        public async Task<bool> updateQuantity(int id, int quantity)
        {
            Product checkProduct = await DBContext.Products.SingleOrDefaultAsync(x => x.ProductId == id);
            if (checkProduct == null)
            {
                return false;
            }
            if (quantity > checkProduct.Quantity)
            {
                checkProduct.Quantity = 0;
            }
            else
            {
                checkProduct.Quantity = checkProduct.Quantity - quantity;
            }
            DBContext.Products.Update(checkProduct);
            DBContext.SaveChanges();
            return true;
        }
    }
}
