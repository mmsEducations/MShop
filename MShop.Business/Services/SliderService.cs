using MShop.Data;
using MShop.Data.Entities;

namespace MShop.Business
{
    public class SliderService : ISliderService
    {
        private readonly MShopContext _context;
        public SliderService(MShopContext context)
        {
            _context = context;
        }

        public List<Slider> GetSliders()
        {
            var sliders = _context.Sliders.ToList();
            return sliders;
        }

    }


}
