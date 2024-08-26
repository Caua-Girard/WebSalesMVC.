using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using C_SalesWebMVC.Data;

var builder = WebApplication.CreateBuilder(args);
string connectionString = builder.Configuration.GetConnectionString("C_SalesWebMVCContext");

builder.Services.AddDbContext<C_SalesWebMVCContext>(options =>

    options.UseMySQL(builder.Configuration.GetConnectionString("C_SalesWebMVCContext") ?? throw new InvalidOperationException("Connection string 'C_SallesWebMVCContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
