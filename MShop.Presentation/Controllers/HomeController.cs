using Microsoft.AspNetCore.Mvc;
using MShop.Business;
using MShop.Business.Dtos;
using MShop.Data;
using MShop.Data.Entities;

namespace MShop.Presentation.Controllers
{
    public class HomeController : Controller
    {

        private readonly MShopContext _context;


        private readonly ICategoryService _categoryService;
        private readonly ISliderService _sliderService;
        private readonly IProductCommentService _productCommentService;

        public HomeController(ICategoryService categoryService, MShopContext context, ISliderService sliderService, IProductCommentService productCommentService)
        {
            _categoryService = categoryService;
            _context = context;
            _sliderService = sliderService;
            _productCommentService =
            _productCommentService = productCommentService;
        }

        //BaseURl/Home/Index
        [HttpGet]
        public IActionResult Index()
        {
            var sliders = _sliderService.GetSliders();

            //HomeModel model = new HomeModel { Sliders = sliders, Categories = _categoryService.GetCategories() };
            var vategories = _context.Categories.ToList();
            return View(sliders);
        }


        [HttpGet]
        public IActionResult Detail()
        {

            var vategories = _categoryService.GetCategories();
            return View(vategories);
        }
    }

    public class HomeModel
    {
        public List<SliderDto> Sliders { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }

        public int Number { get; set; }
    }
}
