
namespace MShop.Presentation.Views.Home.Components.Category
{
    public class ProductViewComponent : ViewComponent
    {
        private readonly IProductService _productService;

        public ProductViewComponent(IProductService productService)
        {
            _productService = productService;
        }
        public IViewComponentResult Invoke(ProductType productType)
        {
            var categories = _productService.GetProductsByType(productType);
            return View(categories);
        }
    }


}
