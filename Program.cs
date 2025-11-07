
using Microsoft.EntityFrameworkCore;
using QuizSQLite.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddDbContext<AppDb>(o => o.UseSqlite("Data Source=quiz.db"));
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();

var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.UseSession();
app.MapControllerRoute(name:"d",pattern:"{controller=Home}/{action=Index}/{id?}");
app.Run();
