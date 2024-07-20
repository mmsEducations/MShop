

using MShop.Repository.Abstract;

namespace MShop.Business
{
    public class SliderService : ISliderService
    {
        private readonly ISliderRepository _sliderRepository;
        private readonly IMapper _mapper;
        public SliderService(ISliderRepository sliderRepository, IMapper mapper)
        {
            _sliderRepository = sliderRepository;
            _mapper = mapper;
        }
        public List<SliderDto> GetSliders()
        {
            var sliders = _sliderRepository.GetAllAsNoTracking();
            List<SliderDto> sliderDtos = _mapper.Map<List<SliderDto>>(sliders);
            return sliderDtos;
        }

    }

}
