using Microsoft.EntityFrameworkCore;
using SportsStore.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IStoreRepository, EFStoreRepository>();

builder.Services.AddDbContext<StoreDbContext>(opts => 
{
    opts.UseSqlServer(builder.Configuration["ConnectionStrings:SportsStoreConnection"]);

});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();
app.MapDefaultControllerRoute();
app.UseRouting();

app.UseAuthorization();

//app.MapRazorPages();
SeedData.EnsurePopulated(app);
app.Run();
