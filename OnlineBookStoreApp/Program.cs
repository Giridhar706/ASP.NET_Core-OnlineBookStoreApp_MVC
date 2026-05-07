using OnlineBookStoreApp.Filters;
using OnlineBookStoreApp.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages();

builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession();

builder.Services.AddSingleton
<
    IBookRepository,
    BookRepository
>();

builder.Services.AddScoped<LoggingFilter>();

builder.Services.AddScoped<AdminFilter>();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern:
    "{controller=Book}/{action=Login}/{id?}"
);

app.Run();