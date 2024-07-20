using Microsoft.EntityFrameworkCore;
using MShop.Data;
using MShop.Data.Entities;
using MShop.Repository.Abstract;

namespace MShop.Repository.Concrate
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(MShopContext context) : base(context)
        {
        }

        public List<Category> GetCategoriesWithProducts()
        {
            var categories = _context.Categories
                                .Include(x => x.Products)
                                .ToList();

            return categories;
        }
    }
}
