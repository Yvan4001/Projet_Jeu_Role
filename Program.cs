using Microsoft.EntityFrameworkCore;
using Projet_Jeu_Role.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ProjetMVCContext>(options =>
				options.UseSqlServer(builder.Configuration.GetConnectionString("ProjetMVCContext") ?? throw new InvalidOperationException("Connection string 'ProjetMVCContext' not found.")));


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
    pattern: "{controller=Users}/{action=Index}/{id?}");

app.Run();
