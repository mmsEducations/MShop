using Microsoft.AspNetCore.Mvc;

namespace MShop.Presentation.Controllers
{
    public class HomeController : Controller
    {
        //BaseURl/Home/Index
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


    }
}
