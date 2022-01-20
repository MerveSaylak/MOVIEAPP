var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc(option => option.EnableEndpointRouting = false);

var app = builder.Build();

//home/index/3
app.UseMvcWithDefaultRoute();
app.Run();

/*app.UseMvc(routes =>
{
    routes.MapRoute(
        name: "default",
        template: "{controller=Home}/{action=Index}/{id?}"
      );
});*/


//app.MapGet("/", () => "Hello World!");
