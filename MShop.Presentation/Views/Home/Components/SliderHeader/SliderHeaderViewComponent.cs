using Microsoft.AspNetCore.Mvc;
using MShop.Business;

namespace MShop.Presentation.Views.Home.Components.SliderHeader
{
    public class SliderHeaderViewComponent : ViewComponent
    {
        private readonly ISliderService _sliderService;

        public SliderHeaderViewComponent(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }
        public IViewComponentResult Invoke()
        {
            var sliders = _sliderService.GetSliders();
            return View(sliders);
        }
    }
}
