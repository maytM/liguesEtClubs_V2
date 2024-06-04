using liguesEtClubs_V2.Models;
using Microsoft.AspNetCore.Builder;
//
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc().AddRazorRuntimeCompilation(); //Besoin d'inclure la biblioth�que (package NuGet) : Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation

builder.Services.AddSingleton<BaseDeDonnees>(); // Permet l'utilisation du Singleton

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseStaticFiles(new StaticFileOptions
    {
        OnPrepareResponse = context => context.Context.Response.Headers.Add("Cache-Control", "no-cache")
    });
}
else
{
    app.UseStaticFiles();
}

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller}/{action}/{id?}",
        defaults: new { controller = "Home", action = "Index" });
});

app.Run();
