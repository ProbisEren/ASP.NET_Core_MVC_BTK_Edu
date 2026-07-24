using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.EntityFrameworkCore;
using StoreApp.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<RepositoryContext>(options => // ProductCOntroller.cs 12-20. satırları yazmamızı sağlıyo
{
    options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection"));
});
 
var app = builder.Build();

app.UseHttpsRedirection();
app.UseRouting();

app.MapControllerRoute(
    name:"default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); // name: ve pattern: yazmaya gerek yok zaten ctrl+p yapınca göüzküyo neyin ne olduğu
//app.MapGet("/", () => "Hello World!");
//app.MapGet("/Btk",() => "Btk Akademi");

app.Run();
