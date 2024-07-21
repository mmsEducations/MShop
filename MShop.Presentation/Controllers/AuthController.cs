using MShop.Business.Interfaces;

namespace MShop.Presentation.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        //Giriş-login
        [HttpGet]
        public IActionResult SignIn()

        {
            return View();
        }

        //Giriş-login
        [HttpPost]
        public async Task<IActionResult> SignIn(UserDto userDto)
        {
            var result = await _authService.SignInUser(userDto);
            if (result)
            {

            }
            else
            {

            }
            return View();
        }


        //Kayıtol-register
        //Auth/SignUp
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }


        [HttpPost]
        //Kayıtol-register
        public async Task<IActionResult> SignUp(UserDto userDto)
        {
            var result = await _authService.SignUpUser(userDto);
            if (result)
            {
                return RedirectToAction("SignIn");
            }
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> SignOut()
        {
            await _authService.SignOutUser();
            return RedirectToAction("Index", "Home");
        }
    }
}

//Idenetiy User management System işlem adımları 
//1) Context ayarının yapılması 
/*
 a) MShopContext : IdentityDbContext<IdentityUser>
 
 b)IdentityUserLogin,IdentityUserRole,IdentityUserToken Tabloların primary key alanlarının set edilmesi 

modelBuilder.Entity<IdentityUserLogin<string>>()
.HasKey(login => new { login.LoginProvider, login.ProviderKey });

modelBuilder.Entity<IdentityUserRole<string>>()
.HasKey(iur => new { iur.UserId, iur.RoleId });

// Define composite primary key for IdentityUserToken<string>
modelBuilder.Entity<IdentityUserToken<string>>()
.HasKey(token => new { token.UserId, token.LoginProvider, token.Name });
 
-------------------
2)Program cs kısmının entegasyonu 

builder.Services.AddIdentity<IdentityUser, IdentityRole>()
.AddEntityFrameworkStores<MShopContext>()
.AddDefaultTokenProviders();

3)Nerede Hangi servise ihtiyacımız varsa onu implemente edip DI ile kullanıyoruz

private readonly UserManager<IdentityUser> _userManager;
private readonly SignInManager<IdentityUser> _signInManager;

public UserService(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
{
    _userManager = userManager;
    _signInManager = signInManager;
}
 
 */