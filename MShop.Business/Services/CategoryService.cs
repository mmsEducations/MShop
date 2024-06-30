using MShop.Data;
using MShop.Data.Entities;

namespace MShop.Business.Services
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
    }


}
