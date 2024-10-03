using FluentValidation;
using FS.BusinessLogicLayer;
using FS.BusinessLogicLayer.Abstract;
using FS.BusinessLogicLayer.Concrete;
using FS.BusinessLogicLayer.Dtos;
using FS.BusinessLogicLayer.ValidationRules;
using FS.DataAccessLayer.Abstract;
using FS.DataAccessLayer.EntityFrameworkCore.Concrete;
using FS.DataAccessLayer.EntityFrameworkCore.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
string connectionString = builder.Configuration.GetConnectionString("local")!;
builder.Services
    .AddDbContext<FsContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddAutoMapper(typeof(IBusinessRegister));

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserDetailRepository, UserDetailRepository>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddScoped<IValidator<CreateUserDto>, CreateUserDtoValidator>();





var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Register}/{id?}");

app.Run();
