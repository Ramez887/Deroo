using Restaurant.Models;

namespace Restaurant.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }

        // علاقة: الطلب يحتوي على عدة عناصر طلب
        public ICollection<OrderItem> OrderItems { get; set; }

    }
}


