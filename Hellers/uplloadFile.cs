using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FOLYFOOD.Hellers
{
    public class uplloadFile
    {
        static string cloudName = "doedovklj";
        static string apiKey = "743786547245974";
        static string apiSecret = "BmEThs-v2v0UE64hLQIT19M4ntk";
        static private readonly Random rnd = new Random();

        static public Account account = new Account(cloudName, apiKey, apiSecret);
        static public Cloudinary _cloudinary = new Cloudinary(account);
        public static async Task<string> UploadFile(IFormFile file,bool checkImage = false)
        {
            if (file == null || file.Length == 0)
            {
                throw new ArgumentException("No file selected.");
            }

            using (var stream = file.OpenReadStream())
            {
                var uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription(file.FileName, stream),
                    PublicId = "xyz-abc" + "_" + DateTime.Now.Ticks + "image" ,// ID công khai tùy ý cho file phải tuyệt đối là không được giống nhau
                };
                if (!checkImage)
                {
                    uploadParams.Transformation = new Transformation().Width(400).Height(400).Crop("fill"); // Cố định kích thước ảnh thành tỷ lệ 3*4 pixel
                }
               
                var uploadResult = await uplloadFile._cloudinary.UploadAsync(uploadParams);

                if (uploadResult.Error != null)
                {
                    // Xử lý lỗi tải lên
                    throw new Exception(uploadResult.Error.Message);
                }

                // Lấy URL công khai của file tải lên
                string imageUrl = uploadResult.SecureUrl.ToString();

                // Tiếp tục xử lý hoặc lưu thông tin về file trong cơ sở dữ liệu


                return imageUrl;
            }
        }
        public static async Task DeleteFile(string url)
        {
            Uri uri = new Uri(url);
            string path = uri.Segments[5];
            int dotIndex = path.LastIndexOf('.'); // Tìm chỉ mục cuối cùng của dấu chấm (.)

            if (dotIndex >= 0)
            {
                path = path.Substring(0, dotIndex); // Lấy phần tên file trước dấu chấm
            
            }
            var deleteParams = new DeletionParams(path)
            {
                ResourceType = ResourceType.Image // Chỉ định loại tài nguyên là hình ảnh
            };

            var deleteResult = await _cloudinary.DestroyAsync(deleteParams);

            if (deleteResult.Error != null)
            {
                // Xử lý lỗi xóa file
                throw new Exception(deleteResult.Error.Message);
            }
        }

        public static async Task<string> UpdateFile(string url, IFormFile file)
        {
            await uplloadFile.DeleteFile(url);
            string link = await uplloadFile.UploadFile(file);
            return link;
        }
    }

}

