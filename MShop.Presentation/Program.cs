var builder = WebApplication.CreateBuilder(args);

//Mvc.1
builder.Services.AddControllersWithViews();

var app = builder.Build();


//Mvc.2
app.UseRouting();
//Mvc.3
app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}"); //3


//wwwroot : activate content 
app.UseStaticFiles();

app.Run();
