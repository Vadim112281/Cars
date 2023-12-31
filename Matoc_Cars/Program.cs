using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Matoc_Cars.Areas.Identity.Data;
using Matoc_Cars.Services;
using Matoc_Cars.Services.CarOnSale;
using Matoc_Cars.Services.OrderCar;
using Matoc_Cars.Services.OrderedCarByUser;
using Matoc_Cars.Services.ProcesOfOrder;
using Matoc_Cars.Services.SellCars;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<AppDbContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddScoped<IFindHaveCar, FindHaveCar>();
builder.Services.AddScoped<IOrderCar, OrderCar>();
builder.Services.AddScoped<ISellCar, SellCar>();
builder.Services.AddScoped<ICarSale, CarSale>();
builder.Services.AddScoped<IOrderedByUser, OrderedByUser>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();