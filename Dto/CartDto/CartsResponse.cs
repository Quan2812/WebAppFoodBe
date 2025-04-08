namespace FOLYFOOD.Dto.CartDto
{
    public class CartsResponse
    {
        public string id { get; set; }
        public string sku { get; set; }
        public string cartItemId { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int discount { get; set; }
        public bool new_product { get; set; }
        public int rating { get; set; }
        public int stock { get; set; }
        public int quantity { get; set; }
        public int saleCount { get; set; }
        public List<string> tag { get; set; } = new List<string>();

        public List<string> category { get; set; } = new List<string>();

        public List<string> image { get; set; } = new List<string>();

        public string shortDescription { get; set; }

        public string fullDescription { get; set; }

    }

}
