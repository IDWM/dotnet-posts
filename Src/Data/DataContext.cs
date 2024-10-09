using dotnet_posts.Src.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_posts.Src.Data
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        public DbSet<Post> Posts { get; set; }
    }
}
