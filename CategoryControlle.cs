using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.Data;
using Restaurant.Models;

namespace Restaurant.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        // 🟩 عرض كل التصنيفات
        [HttpGet]
        public IActionResult Index()
        {
            var categories = _context.Categories.ToList();
            return View(categories);
        }

        // 🟨 عرض نموذج إضافة تصنيف
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // 🟧 حفظ التصنيف الجديد
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {
            Console.WriteLine("دخلنا على الأكشن Create [POST]");
            Console.WriteLine($"ModelState.IsValid = {ModelState.IsValid}");
            Console.WriteLine($"البيانات المستلمة: {category.Name} - {category.Description}");

            if (ModelState.IsValid)
            {
                _context.Categories.Add(category);
                _context.SaveChanges();
                Console.WriteLine("تم حفظ التصنيف بنجاح");
                return RedirectToAction("Index");
            }

            Console.WriteLine("النموذج غير صالح، لم يتم الحفظ.");
            return View(category);
        }

        // 🟥 عرض تأكيد الحذف
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var category = _context.Categories.Find(id);
            if (category == null)
                return NotFound();

            return View(category);
        }

        // 🔴 تنفيذ الحذف
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var category = _context.Categories.Find(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}











