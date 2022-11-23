using BusinessLayer.Mapping;
using BusinessLayer.Services.Appointments;
using BusinessLayer.Services.Categories;
using BusinessLayer.Services.Cities;
using BusinessLayer.Services.Salons;
using BusinessLayer.Services.SalonServicesServices;
using BusinessLayer.Services.Services;
using CoreLayer.DataAccess.Repositories;
using CoreLayer.MvcUI;
using DataAccessLayer.AppContext;
using DataAccessLayer.Entities;
using DataAccessLayer.EntityFramework;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// automapper
builder.Services.AddAutoMapper(typeof(MappingProfile));

// DbContext 
builder.Services.AddDbContext<ApplicationDbContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Identity 
builder.Services.AddDefaultIdentity<ApplicationUser>(IdentityOptionsProvider.GetIdentityOptions)
    .AddRoles<ApplicationRole>().AddEntityFrameworkStores<ApplicationDbContext>();


// Repository
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(EfGenericRepository<>));

// Servisler
builder.Services.AddScoped<ICategoriesService, CategoriesService>();
builder.Services.AddScoped<IServicesService, ServicesService>();
builder.Services.AddScoped<ICitiesService, CitiesService>();
builder.Services.AddScoped<ISalonsService, SalonsService>();
builder.Services.AddScoped<ISalonServicesService, SalonServicesService>();
builder.Services.AddScoped<IAppointmentsService, AppointmentsService>();

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
app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(
               endpoints =>
               {
                   endpoints.MapControllerRoute("areaRoute", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                   endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
                   endpoints.MapRazorPages();
               });
app.Run();
