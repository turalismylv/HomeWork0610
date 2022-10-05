using front_to_back.DAL;
using Microsoft.EntityFrameworkCore;

#region Builder

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(connectionString));

#endregion

#region App

var app = builder.Build();
app.MapDefaultControllerRoute();
app.UseStaticFiles();
app.Run();

#endregion
