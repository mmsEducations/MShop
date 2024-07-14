namespace MShop.Presentation.Views.Home.Components.ProductInfo
{
    public class ProductInfoViewComponent : ViewComponent
    {

        public ProductInfoViewComponent()
        {
        }
        public IViewComponentResult Invoke(ProductDto productDto)
        {
            return View(productDto);
        }
    }


}
