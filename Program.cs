using dotnet_posts.Src.Data;
using dotnet_posts.Src.Helpers;
using dotnet_posts.Src.Interfaces;
using dotnet_posts.Src.Repositories;
using dotnet_posts.Src.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.Configure<CloudinarySettings>(
    builder.Configuration.GetSection("CloudinarySettings")
);
builder.Services.AddScoped<IPostRepository, PostRepository>();
builder.Services.AddScoped<IPhotoService, PhotoService>();
builder.Services.AddControllers();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<DataContext>();
    await context.Database.MigrateAsync();
}
app.MapControllers();

app.Run();
