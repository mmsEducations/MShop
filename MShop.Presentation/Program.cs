
var builder = WebApplication.CreateBuilder(args);

//Mvc.1
builder.Services.AddControllersWithViews();

//Business Services added.
builder.Services.AddServiceExtensions();


//AutoMapper Profile added.
builder.Services.AddAutoMapperExtensions();

builder.Services.AddDbContext<MShopContext>(options =>
{
    options.UseSqlServer(@"Server=.;Database=MShop;Trusted_Connection=True;Encrypt=False;");
});

//Identity Entegration
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<MShopContext>()
    .AddDefaultTokenProviders();

var app = builder.Build();

//Mvc.2
app.UseRouting();
//Mvc.3
app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}"); //3

app.UseAuthorization();

//wwwroot : activate content 
app.UseStaticFiles();

app.Run();
