
using Microsoft.EntityFrameworkCore;

namespace MShop.Business
{
    public class CategoryService : ICategoryService
    {
        private readonly MShopContext _context;
        private readonly IMapper _mapper;
        public CategoryService(MShopContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<CategoryDto> GetCategories()
        {
            var categories = _context.Categories
                                     .ToList();
            var categoryDtos = _mapper.Map<List<CategoryDto>>(categories);
            return categoryDtos;
        }

        public List<CategoryDto> GetCategoriesWithProducts()
        {
            var categories = _context.Categories
                                      .Include(x => x.Products)
                                     .ToList();
            var categoryDtos = _mapper.Map<List<CategoryDto>>(categories);
            return categoryDtos;
        }

        public CategoryDto GetCategoryById(int id)
        {
            var category = _context.Categories
                                   .Where(c => c.CategoryId == id)
                                   .FirstOrDefault();
            var categoryDto = _mapper.Map<CategoryDto>(category);

            return categoryDto;
        }

        public bool InsertCategory(Category category)
        {
            _context.Categories.Add(category);
            return _context.SaveChanges() > 0;
        }

    }

}
