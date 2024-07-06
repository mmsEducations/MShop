using AutoMapper;
using MShop.Business.Dtos;
using MShop.Data;

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
            List<SliderDto> sliderDtos = _mapper.Map<List<SliderDto>>(sliders);
            return sliderDtos;
        }

    }


}
