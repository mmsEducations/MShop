using MShop.Repository.Abstract;

namespace MShop.Business
{
    public class CategoryService : ICategoryService
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public List<CategoryDto> GetCategories()
        {
            //var categories = _context.Categories.ToList();
            var categories = _categoryRepository.GetAllAsNoTracking();
            var categoryDtos = _mapper.Map<List<CategoryDto>>(categories);
            return categoryDtos;
        }

        public List<CategoryDto> GetCategoriesWithProducts()
        {
            var categoryDtos = _mapper.Map<List<CategoryDto>>(_categoryRepository.GetCategoriesWithProducts());
            return categoryDtos;
        }

        public CategoryDto GetCategoryById(int id)
        {
            //var category = _context.Categories .Where(c => c.CategoryId == id).FirstOrDefault();
            var category = _categoryRepository.Get(id);
            var categoryDto = _mapper.Map<CategoryDto>(category);
            return categoryDto;
        }

        public bool InsertCategory(Category category)
        {
            //_context.Categories.Add(category);
            //return _context.SaveChanges() > 0;

            return _categoryRepository.Add(category);
        }

    }

}
