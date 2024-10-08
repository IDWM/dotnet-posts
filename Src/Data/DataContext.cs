using dotnet_images.Src.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_images.Src.Data
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        public DbSet<Post> Posts { get; set; }
    }
}
