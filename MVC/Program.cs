using BLL.Services.Abstracts;
using BLL.Services.Concretes;
using DAL.Context;
using DAL.Repository.Abstracts;
using DAL.Repository.Concretes;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//AddDBContext

builder.Services.AddDbContext<ProjectContext>(options => options.UseSqlServer("server=.;database=EcommerceDB;Trusted_Connection=True;TrustServerCertificate=True;"));

//Services
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

//Service Managers

builder.Services.AddScoped(typeof(IServiceManager<>), typeof(ServiceManager<>));

//CategoryService

builder.Services.AddScoped<ICategoryService, CategoryService>();


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

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
    );
});

app.Run();
