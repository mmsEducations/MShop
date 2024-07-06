using MShop.Business.Mapping;

namespace MShop.Presentation.Extensions
{
    public static class AutoMapperExtensions
    {
        public static void AddAutoMapperExtensions(this IServiceCollection services)
        {
            //Mapping added to here 
            services.AddAutoMapper(typeof(SliderMappingProfile));

        }
    }
}
