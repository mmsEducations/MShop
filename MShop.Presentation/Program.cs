using MShop.Data;
using MShop.Presentation.Extensions;

var builder = WebApplication.CreateBuilder(args);

//Mvc.1
builder.Services.AddControllersWithViews();

//Business Services added.
builder.Services.AddServiceExtensions();


//AutoMapper Profile added.
builder.Services.AddAutoMapperExtensions();

//builder.Services.AddDbContext<MShopContext>(options =>
//{
//    options.UseSqlServer("Server=.;Database=MShop;Trusted_Connection=True;Encrypt=False;");
//});

builder.Services.AddDbContext<MShopContext>();

var app = builder.Build();


//Mvc.2
app.UseRouting();
//Mvc.3
app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}"); //3


//wwwroot : activate content 
app.UseStaticFiles();

app.Run();
