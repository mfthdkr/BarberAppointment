using BarberAppointment.DataAccessLayer.Contexts;
using BusinessLayer.Mapping;
using BusinessLayer.Services.Abstract;
using BusinessLayer.Services.Concrete;
using CoreLayer.DataAccess.Repositories;
using DataAccessLayer.Entities;
using DataAccessLayer.EntityFramework;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// automapper
builder.Services.AddAutoMapper(typeof(MappingProfile));

// DbContext 
builder.Services.AddDbContext<BarberAppointmentContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("Connection1")));

// Identity 
builder.Services.AddDefaultIdentity<User>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 6;
}).AddRoles<Role>().AddEntityFrameworkStores<BarberAppointmentContext>();

// Repository
builder.Services.AddScoped(typeof(IRepositoryBase<>), typeof(EfRepositoryBase<>));

// Servisler
builder.Services.AddScoped<IBarbersService, BarbersManager>();
builder.Services.AddScoped<IAppointmentsService, AppointmentsManager>();
builder.Services.AddScoped<ICitiesService, CitiesManager>();

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


app.MapControllerRoute(
    name: "MyArea",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();
