using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Restaurant.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "الاسم مطلوب")]
        [StringLength(100, ErrorMessage = "الاسم لا يمكن أن يزيد عن 100 حرف")]
        public string Name { get; set; }

        [Required(ErrorMessage = "الوصف مطلوب")]
        [StringLength(250, ErrorMessage = "الوصف لا يمكن أن يزيد عن 250 حرف")]
        public string Description { get; set; }

        // علاقة: كل تصنيف يحتوي على عدة منتجات
        public ICollection<Product> Products { get; set; }
    }
}

