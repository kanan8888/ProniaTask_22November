using Microsoft.EntityFrameworkCore;
using WebApplication_Pronia_AB107_22November.Models;

namespace WebApplication_Pronia_AB107_22November.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
            
        }
        public DbSet<Slider>Sliders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagProduct> TagProducts { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
    }
}
