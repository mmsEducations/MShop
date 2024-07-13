namespace MShop.Business
{
    public class ProductCommentService : IProductCommentService
    {
        private readonly MShopContext _context;
        public ProductCommentService(MShopContext context)
        {
            _context = context;
        }

        public List<ProductComment> GetProductComments()
        {
            var productComments = _context.ProductComments.ToList();
            return productComments;
        }
    }

}
