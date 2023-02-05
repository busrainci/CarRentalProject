using Business.Abstract;
using Business.Concrete;
using DataAccess.Absract;
using DataAccess.Concrete.EntityFramework;

// Add services to the container.
//builder.Services.AddControllersWithViews();
//builder.Services.AddEndpointsApiExplorer();



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();



builder.Services.AddControllers();
builder.Services.AddSingleton<ICarService,CarManager>();
builder.Services.AddSingleton<ICarDal,EfCarDal>();
builder.Services.AddSingleton<IColorService, ColorManager>();
builder.Services.AddSingleton<IColorDal, EfColorDal>();
builder.Services.AddSingleton<IBrandService, BrandManager>();
builder.Services.AddSingleton<IBrandDal, EfBrandDal>();
builder.Services.AddSingleton<ICustomerService, CustomerManager>();
builder.Services.AddSingleton<ICustomerService, CustomerManager>();
builder.Services.AddSingleton<ICustomerDal, EfCustomerDal>();
builder.Services.AddSingleton<IRentalService, RentalManager>();
builder.Services.AddSingleton<IRentalDal, EfRentalDal>();
builder.Services.AddSingleton<IUserService, UserManager>();
builder.Services.AddSingleton<IUserDal, EfUserDal>();
 



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
