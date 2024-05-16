using Internet_Service_project.Models;
using Microsoft.EntityFrameworkCore;

namespace Internet_Service_project.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 


        }

        public DbSet<Product>Products { get; set; }
        public DbSet<Category>Categories { get; set; }
    }
}
