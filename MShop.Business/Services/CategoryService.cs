using MShop.Data;
using MShop.Data.Entities;

namespace MShop.Business
{
    public class CategoryService : ICategoryService
    {
        private readonly MShopContext _context;
        public CategoryService(MShopContext context)
        {
            _context = context;
        }

        public List<Category> GetCategories()
        {
            var categories = _context.Categories.ToList();
            return categories;
        }

        public Category GetCategoryById(int id)
        {
            var category = _context.Categories
                                   .Where(c => c.CategoryId == id)
                                   .FirstOrDefault();
            return category;
        }

        public bool InsertCategory(Category category)
        {
            _context.Categories.Add(category);
            return _context.SaveChanges() > 0;
        }

    }

}
