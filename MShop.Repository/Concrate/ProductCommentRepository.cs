using MShop.Data;
using MShop.Data.Entities;
using MShop.Repository.Abstract;

namespace MShop.Repository.Concrate
{
    public class ProductCommentRepository : Repository<ProductComment>, IProductCommentRepository
    {
        public ProductCommentRepository(MShopContext context) : base(context)
        {
        }
    }
}
