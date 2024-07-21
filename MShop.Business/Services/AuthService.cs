
namespace MShop.Business
{
    public class AuthService : IAuthService
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AuthService(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<bool> SignInUser(UserDto userDto)
        {
            var user = new IdentityUser
            {
                UserName = userDto.UserName,
                Email = userDto.UserName
            };

            //Kullanı username'i veya email'i üzerinden kullanıcnın sistemdde mevcut olup olmadığını bulan kod 
            var userInfo = await _userManager.FindByEmailAsync(userDto.UserName);
            var userInfoByName = await _userManager.FindByNameAsync(userDto.UserName);

            //Kullanı adının ve şifresinin  sistemde mevcut olup olmadığını bulan kod 
            var resultSignIn = await _signInManager.PasswordSignInAsync(user.UserName, userDto.Password, isPersistent: userDto.RememberMe, lockoutOnFailure: false);

            return resultSignIn.Succeeded;
        }

        // Register User
        public async Task<bool> SignUpUser(UserDto userDto)
        {
            var user = new IdentityUser
            {
                UserName = userDto.UserName,
                Email = userDto.UserName
            };

            //_userManager.AddClaimAsync(user,new Claim{ Type ="" ,"" })

            //Kullanıcı kaydı için "UserManager"'ın CreateAsync metodu çağrılır 
            var userCreate = await _userManager.CreateAsync(user, userDto.Password);

            return userCreate.Succeeded;
        }

        //Sistemden logout olamızı sağlar 
        public async Task SignOutUser()
        {
            await _signInManager.SignOutAsync();
        }

    }
}
