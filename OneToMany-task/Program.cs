using System;
using Microsoft.EntityFrameworkCore;
using OneToMany_task.Data;
using OneToMany_task.Services;
using OneToMany_task.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService,CategoryService>();
builder.Services.AddScoped<IExpertService,ExpertService>();
builder.Services.AddScoped<IExpertImageService, ExpertImageService>();


builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("FiorellaDatabaseP418"));
});
var app = builder.Build();


app.UseHttpsRedirection();
app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();