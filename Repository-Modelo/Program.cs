using Microsoft.EntityFrameworkCore;
using Repository_Modelo.Complements;
using Repository_Modelo.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IUsuarios, Usuarios>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DbContext_Users>(opc =>
    opc.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionSQL")));
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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
