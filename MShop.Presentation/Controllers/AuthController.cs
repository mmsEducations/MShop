namespace MShop.Presentation.Controllers
{
    public class AuthController : Controller
    {
        //Giriş-login
        public IActionResult SignIn()
        {
            return View();
        }

        //Kayıtol-register
        public IActionResult SignUp()
        {
            return View();
        }
    }
}
