
namespace MShop.Business.Mapping
{
    public class CategoryMappingProfile : Profile
    {
        public CategoryMappingProfile()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
        }
    }
}
