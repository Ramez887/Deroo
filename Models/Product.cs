using Restaurant.Models;
namespace Restaurant.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }

        // علاقة: المنتج ينتمي لتصنيف
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}



