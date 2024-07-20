using MShop.Data;
using MShop.Data.Entities;
using MShop.Repository.Abstract;

namespace MShop.Repository.Concrate
{
    public class SliderRepository : Repository<Slider>, ISliderRepository
    {
        public SliderRepository(MShopContext context) : base(context)
        {
        }
    }
}
