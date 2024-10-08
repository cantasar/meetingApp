var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //MVC

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

//controller/action/id
// app.MapDefaultControllerRoute();

app.MapControllerRoute(
    name: "Default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();