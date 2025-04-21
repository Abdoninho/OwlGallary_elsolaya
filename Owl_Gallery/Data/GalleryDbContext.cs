using Microsoft.EntityFrameworkCore;
using Owl_Gallery.Models;

namespace Owl_Gallery.Data
{
    public class GalleryDbContext :DbContext
    {

        public GalleryDbContext(DbContextOptions<GalleryDbContext> options) : base(options){}


        public DbSet<Product> Products { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Register> Registers { get; set; }
    }
}
