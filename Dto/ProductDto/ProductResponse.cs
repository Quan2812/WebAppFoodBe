namespace FOLYFOOD.Dto.ProductDto
{
    public class ProductResponse
    {
        public string id { get; set; }
        public string sku { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int discount { get; set; }
        public bool new_product { get; set; }
        public int rating { get; set; }
        public int stock { get; set; }
        public int saleCount { get; set; }
        public List<string> tag { get; set; } = new List<string>();

        public List<string> category { get; set; } = new List<string>();
        
        public List<string> image { get; set; } = new List<string>();

        public string shortDescription { get; set; }

        public string fullDescription { get; set; }


    }
    
}
//"id": "34",
//    "sku": "asdf156",
//    "name": "Lorem ipsum fruit one",
//    "price": 15.6,
//    "discount": 0,
//    "new": false,
//    "rating": 4,
//    "saleCount": 90,
//    "category": ["organic food"],
//    "tag": ["organic food"],
//    "stock": 15,
//    "image": [
//      "https://bizweb.dktcdn.net/thumb/1024x1024/100/385/875/products/7da69725e38719d94096-ca2ca1c4-eb08-40ca-8b73-f2cdd02ca674.jpg?v=1671605304390",
//      "/assets/img/product/fruits/2.jpg",
//      "/assets/img/product/fruits/3.jpg",
//      "/assets/img/product/fruits/4.jpg",
//      "/assets/img/product/fruits/5.jpg"
//    ],
//    "shortDescription": "Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur.",
//    "fullDescription": "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt."