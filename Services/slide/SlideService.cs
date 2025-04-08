using CloudinaryDotNet.Actions;
using FOLYFOOD.Dto;
using FOLYFOOD.Dto.slideDto;
using FOLYFOOD.Entitys;
using Microsoft.EntityFrameworkCore;

namespace FOLYFOOD.Services.slide
{
    public class SlideService
    {
        public readonly Context DBContext;
        public SlideService() {
            DBContext = new Context();
        }
        public async Task<IQueryable<FOLYFOOD.Entitys.Slides>> GetSlides()
        {
            return DBContext.Slides.Include(x=>x.slides).OrderByDescending(x=>x.IsShow).AsNoTracking();
        }
        public async Task<FOLYFOOD.Entitys.Slides> ShowSlideFrontend()
        {
            return DBContext.Slides.Include(x=>x.slides).SingleOrDefault(x => x.IsShow == 1);
        }
        public async Task<RetunObject<FOLYFOOD.Entitys.Slides>> DeleteSlide(int slideId)
        {
            FOLYFOOD.Entitys.Slides Slides = DBContext.Slides.SingleOrDefault(x => x.SlidesId == slideId && x.IsShow != 1);
            if (Slides == null)
            {
                return new RetunObject<Slides>()
                {
                    data = null,
                    mess = "Không tồn tại không",
                    statusCode = 400,
                };
            }
            DBContext.Slides.Remove(Slides);
            DBContext.SaveChanges();
            return new RetunObject<Slides>()
            {
                data = Slides,
                mess = "Xóa thành công",
                statusCode = 200,
            };
        }
        public async Task<RetunObject<FOLYFOOD.Entitys.Slides>> CreateSlide(SildeRequest sildeRequest)
        {
            if (string.IsNullOrEmpty(sildeRequest.SlidesName))
            {
                return new RetunObject<Slides>()
                {
                    data = null,
                    mess = "dữ liệu rỗng",
                    statusCode = 400,
                };
            }

            FOLYFOOD.Entitys.Slides Slides = new FOLYFOOD.Entitys.Slides()
            {
                CreatedAt = DateTime.Now,
                IsShow = 0,
                SlidesName = sildeRequest.SlidesName,   
            };

            DBContext.Slides.AddAsync(Slides);
            DBContext.SaveChanges();

            return new RetunObject<Slides>()
            {
                data = Slides,
                mess = "thêm thành công",
                statusCode = 200,
            };
        }

        public async Task<RetunObject<FOLYFOOD.Entitys.Slides>> CreateItemSlide(SildeItemRequest sildeRequest)
        {
            FOLYFOOD.Entitys.Slides Slides = DBContext.Slides.SingleOrDefault(x=>x.SlidesId == sildeRequest.SlidesId);
            if (Slides == null)
            {
                return new RetunObject<Slides>()
                {
                    data = null,
                    mess = "thêm thất bại",
                    statusCode = 400,
                };
            }
            List<FOLYFOOD.Entitys.Slide> slides = new List<FOLYFOOD.Entitys.Slide>();
            foreach (var item in sildeRequest.Slides)
            {
                slides.Add(new FOLYFOOD.Entitys.Slide()
                {
                    CreatedAt = DateTime.Now,
                    SlideImage = item.SlideImage,
                    SlidesId = Slides.SlidesId,
                    Title = item.Title,
                    SubTitle = item.SubTitle,
                    Url = item.Url,
                });
            }
            DBContext.Slide.AddRange(slides);
            DBContext.SaveChanges();
            return new RetunObject<Slides>()
            {
                data = Slides,
                mess = "ok",
                statusCode = 200,
            };
        }

        public async Task<RetunObject<FOLYFOOD.Entitys.Slides>> ActiveSlide(int slidesId)
        {
            FOLYFOOD.Entitys.Slides Slides = DBContext.Slides.SingleOrDefault(x => x.SlidesId == slidesId);
            if (Slides == null)
            {
                return new RetunObject<Slides>()
                {
                    data = null,
                    mess = "hiện thất bại",
                    statusCode = 400,
                };
            }
            if(Slides.IsShow == 1)
            {
                return new RetunObject<Slides>()
                {
                    data = null,
                    mess = "đã được hiển thị rồi    ",
                    statusCode = 400,
                };
            }
            Slides.IsShow = 1;
            DBContext.Slides.Update(Slides);
            DBContext.SaveChanges();
            var listSlide = DBContext.Slides.SingleOrDefault(x => x.IsShow == 1 && x.SlidesId != slidesId);
            listSlide.IsShow = 0;
            DBContext.Slides.Update(listSlide);
            DBContext.SaveChanges();
            return new RetunObject<Slides>()
            {
                data = Slides,
                mess = "hiện thành công",
                statusCode = 200,
            };
        }

    }
}
