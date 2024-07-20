

using MShop.Repository.Abstract;
using MShop.Repository.Concrate;

namespace MShop.Presentation.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddServiceExtensions(this IServiceCollection services)
        {
            //Service added.
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();

            services.AddScoped<ISliderService, SliderService>();
            services.AddScoped<ISliderRepository, SliderRepository>();


            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductRepository, ProductRepository>();


            services.AddScoped<IProductCommentService, ProductCommentService>();
            services.AddScoped<IProductCommentRepository, ProductCommentRepository>();

        }
    }
}
