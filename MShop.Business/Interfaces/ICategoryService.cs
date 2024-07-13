namespace MShop.Business
{
    public interface ICategoryService
    {
        List<CategoryDto> GetCategories();

        CategoryDto GetCategoryById(int id);

        bool InsertCategory(Category category);
    }
}