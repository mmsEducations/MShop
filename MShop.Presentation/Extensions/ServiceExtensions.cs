

namespace MShop.Presentation.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddServiceExtensions(this IServiceCollection services)
        {
            //Service added.
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ISliderService, SliderService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductCommentService, ProductCommentService>();
        }
    }
}
