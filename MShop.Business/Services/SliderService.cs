

namespace MShop.Business
{
    public class SliderService : ISliderService
    {
        private readonly MShopContext _context;
        private readonly IMapper _mapper;
        public SliderService(MShopContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<SliderDto> GetSliders()
        {
            var sliders = _context.Sliders.ToList();
            //List<SliderDto> işlemdençıkan veri = _mapper.Map<Geriye döndüreceğimiz yeni verinin türü(tipi)>(Dönüştürülecek veri);
            // List<SliderDto> sliderDtos = _mapper.Map<sonuc>(kaynak);

            List<SliderDto> sliderDtos = _mapper.Map<List<SliderDto>>(sliders);
            return sliderDtos;
        }

    }

}
