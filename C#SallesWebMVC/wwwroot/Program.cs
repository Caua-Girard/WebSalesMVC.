using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using C_SalesWebMVC.Data;
using C_SallesWebMVC.Data;

var builder = WebApplication.CreateBuilder(args);
string connectionString = builder.Configuration.GetConnectionString("C_SalesWebMVCContext");


builder.Services.AddDbContext<C_SalesWebMVCContext>(options =>

    options.UseMySQL(builder.Configuration.GetConnectionString("C_SalesWebMVCContext") ?? throw new InvalidOperationException("Connection string 'C_SallesWebMVCContext' not found.")));

builder.Services.AddScoped<SeedingService>(); //adiciona o serviço SeedingService ao contêiner de dependências da aplicação com um ciclo de vida do tipo Scoped
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

app.Services.CreateScope().ServiceProvider.GetRequiredService<SeedingService>().Seed(); // realiza a injeção de dependência e executa o serviço de "seeding" de dados
app.UseHttpsRedirection();
app.UseStaticFiles();
    
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
