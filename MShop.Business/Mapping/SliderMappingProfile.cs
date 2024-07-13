
namespace MShop.Business.Mapping
{
    public class SliderMappingProfile : Profile
    {
        public SliderMappingProfile()
        {
            // CreateMap<Kaynak, Hedef>()/
            // CreateMap<DönüştürlecekTip, YeniEldeedilecekModel>()/
            CreateMap<Slider, SliderDto>()//Slider adlı kaynağı "SliderDto" adlı hedefe dönüştürüyoruz
           .ReverseMap();//Yukarıdaki dönüşümün tersini yapar

        }
    }
}
