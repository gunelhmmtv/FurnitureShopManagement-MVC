using FluentValidation;
using FS.BusinessLogicLayer;
using FS.BusinessLogicLayer.Abstract;
using FS.BusinessLogicLayer.Concrete;
using FS.BusinessLogicLayer.Dtos;
using FS.BusinessLogicLayer.ValidationRules;
using FS.DataAccessLayer.Abstract;
using FS.DataAccessLayer.EntityFrameworkCore.Concrete;
using FS.DataAccessLayer.EntityFrameworkCore.Contexts;
using FS.ExternalServices.Interfaces;
using FS.ExternalServices.Models;
using FS.ExternalServices.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
string connectionString = builder.Configuration.GetConnectionString("local")!;
builder.Services
    .AddDbContext<FsContext>(options => options.UseSqlServer(connectionString));

var emailConfigurations = builder.Configuration.GetSection("SmtpSetting");
builder.Services.Configure<SmtpSetting>(emailConfigurations);

builder.Services.AddTransient<IEmailService, EmailService>();

builder.Services.AddAutoMapper(typeof(IBusinessRegister));

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserDetailRepository, UserDetailRepository>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();



builder.Services.AddScoped<IValidator<CreateUserDto>, CreateUserDtoValidator>();
builder.Services.AddScoped<IValidator<AddProductDto>, AddProductDtoValidator>();





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
    pattern: "{controller=Product}/{action=Index}/{id?}");

app.Run();
