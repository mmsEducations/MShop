using MShop.Data.Entities;

namespace MShop.Repository.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        List<Category> GetCategoriesWithProducts();
    }
}
