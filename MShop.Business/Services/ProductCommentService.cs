using MShop.Repository.Abstract;

namespace MShop.Business
{
    public class ProductCommentService : IProductCommentService
    {
        private readonly IProductCommentRepository _productCommentRepository;

        public ProductCommentService(IProductCommentRepository productCommentRepository)
        {
            _productCommentRepository = productCommentRepository;
        }

        public List<ProductComment> GetProductComments()
        {
            return _productCommentRepository.GetAllAsNoTracking();
        }
    }

}
