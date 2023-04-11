using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PocketSafe.DAL.EF.Repositories;
using SnakeGame.DAL.EF;
using SnakeGame.Domain.Repository;
using SnakeGame.Logic;
using SnakeGame.PostgresMigrate;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<GameService>();
var connectionString = "host=localhost; port=5432; database=Snake; username=postgres; password=123;";
PostgresMigrator.Migrate(connectionString);

builder.Services.AddDbContext<PostgreeContext>(
    options => { 
        options.UseNpgsql(connectionString);
        options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking); 
});
builder.Services.AddScoped<IGameRepository, GameEFPostgreeRepository>();

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
    pattern: "{controller=Snakes}/{action=Snake}/{id?}");

app.Run();
