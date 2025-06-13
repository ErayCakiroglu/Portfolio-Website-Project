using Microsoft.EntityFrameworkCore;
using Portfolio_Website.DAL_Data_Access_Layer_.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();builder.Services.AddDbContext<PortfolioWebsiteContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


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
    name: "experience",
    pattern: "experiences/{action=ExperienceList}/{id?}",
    defaults: new { controller = "Experience" });

app.MapControllerRoute(
    name: "todolist",
    pattern: "todolist/{action=Index}/{id?}",
    defaults: new { controller = "ToDoList" });

// Genel fallback route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=ToDoList}/{action=Index}/{id?}");


// app.MapControllerRoute(
//     name: "default",
//     pattern: "{controller=Default}/{action=Index}/{id?}");

// app.MapControllerRoute(
//     name: "experience",
//     pattern: "{controller=Experience}/{action=ExperienceList}/{id?}");

app.Run();