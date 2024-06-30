using MShop.Data.Entities;

namespace MShop.Business.Services
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
    }
}