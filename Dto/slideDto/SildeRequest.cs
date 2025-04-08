namespace FOLYFOOD.Dto.slideDto
{
    public class SildeRequest
    {
        public string SlidesName { get; set; }
    }

    public class SildeItemRequest
    {
        public int SlidesId { get; set; }
        public List<ItemSlide> Slides { get; set; }
    }

    public class ItemSlide
    {
        public string Title { get; set; }
        public string SlideImage { get; set; }
        public string SubTitle { get; set; }
        public string Url { get; set; }
    }
}
