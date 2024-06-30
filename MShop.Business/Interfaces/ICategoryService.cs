using MShop.Data.Entities;

namespace MShop.Business
{
    public interface ICategoryService
    {
        List<Category> GetCategories();

        Category GetCategoryById(int id);

        bool InsertCategory(Category category);
    }
}