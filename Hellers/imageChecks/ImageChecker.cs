using Microsoft.AspNetCore.Http;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

namespace FOLYFOOD.Hellers.imageChecks
{
    public class ImageChecker
    {
        
        // hàm này để kiểm tra nếu ảnh quá lớn thì nó sẽ trả về Exception 
        public static bool IsImage(IFormFile imageFile, int maxSizeInBytes = (5 * 1024 * 1024))
        {
            // mặc định nếu người dùng không truyền vào thì file nó phải mặc định là ảnh và dung lượng của nó không được
            try
            {
                using (var image = Image.Load<Rgba32>(imageFile.OpenReadStream()))
                {
                    // Kiểm tra định dạng của ảnh
                    if (image.Width > 0 && image.Height > 0)
                    {
                        // Kiểm tra dung lượng của ảnh
                        if (imageFile.Length <= maxSizeInBytes)
                        {
                            return true;
                        }
                        if (imageFile.Length > maxSizeInBytes)
                        {
                            throw new NotImplementedException("file quá lớnh");
                        }

                    }
                }
            }
            catch
            {

                if (imageFile.Length > maxSizeInBytes)
                {
                    throw new NotImplementedException("file quá lớn");
                }
                else
                {

                    throw new NotImplementedException("file này không phải file có định dạng ảnh");
                
                }
            }

            return false;
        }
    }
}
