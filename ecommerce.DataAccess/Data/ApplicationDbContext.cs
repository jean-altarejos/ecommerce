using Microsoft.EntityFrameworkCore;
using ecommerce.Models;

namespace ecommerceApp.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Tops", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Bottoms", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Undergarments", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Accessories", DisplayOrder = 4 }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Printed T-shirt",
                    SKU = "T12345",
                    Brand = "No Brand",
                    Color = "White",
                    Size = "Large",
                    CategoryId = 1,
                    ListPrice = 150,
                    Description = "Cute cat printed tshirt"
                }
                ,
                new Product
                {
                    Id = 2,
                    Name = "Brown Shirt with Beads in it",
                    SKU = "T12346",
                    Brand = "No Brand",
                    Color = "Beige",
                    Size = "Large",
                    CategoryId = 1,
                    ListPrice = 350,
                    Description = "A beautiful dress made by yours truly."
                }
                , new Product
                {
                    Id = 3,
                    Name = "Black Blouse",
                    SKU = "T12347",
                    Brand = "No Brand",
                    Color = "Black",
                    Size = "Large",
                    CategoryId = 1,
                    ListPrice = 550,
                    Description = "A Black beauty"
                }
                , new Product
                {
                    Id = 4,
                    Name = "Waffle Knit Tee",
                    SKU = "T12348",
                    Brand = "No Brand",
                    Color = "Brown",
                    Size = "Large",
                    CategoryId = 1,
                    ListPrice = 450,
                    Description = "An office outfit must have"
                }
                , new Product
                {
                    Id = 5,
                    Name = "Sleeveless Shirt",
                    SKU = "T12349",
                    Brand = "No Brand",
                    Color = "Gray",
                    Size = "Large",
                    CategoryId = 1,
                    ListPrice = 150,
                    Description = "Cotton Tee"
                }
                , new Product
                {
                    Id = 6,
                    Name = "Blue Polo Shirt",
                    SKU = "T123410",
                    Brand = "No Brand",
                    Color = "Blue",
                    Size = "Large",
                    CategoryId = 1,
                    ListPrice = 350,
                    Description = "Versatile top good for work and summer"
                }
            );
        }
    }
}
