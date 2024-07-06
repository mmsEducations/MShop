using MShop.Data.Entities;

namespace MShop.Business
{
    public interface IProductCommentService
    {
        List<ProductComment> GetProductComments();
    }
}