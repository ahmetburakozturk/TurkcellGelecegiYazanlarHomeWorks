using BootShop.Entities;
using Microsoft.EntityFrameworkCore;

namespace BootShop.DataAccess
{
    public class bootShopDbContext : DbContext
    {
        public bootShopDbContext(DbContextOptions<bootShopDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    ID = 1,
                    Name = "Telefon"
                },
                new Category
                {
                    ID = 2,
                    Name = "Laptop"
                },
                new Category { ID = 3, Name = "Tablet" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ID = 1,
                    Name = "İphone 11",
                    ImageUrl = "https://productimages.hepsiburada.net/s/49/222-222/10986386391090.jpg/format:webp",
                    Price = 13000,
                    Discount = 0.05,
                    CategoryId = 1
                },
                new Product
                {
                    ID = 2,
                    Name = "Samsung Note 20",
                    ImageUrl = "https://productimages.hepsiburada.net/s/41/222-222/10698884743218.jpg/format:webp",
                    Price = 13000,
                    Discount = 0.05,
                    CategoryId = 1
                },
                new Product
                {
                    ID = 3,
                    Name = "Xiomi Mi 11",
                    ImageUrl = "https://productimages.hepsiburada.net/s/131/222-222/110000082286300.jpg/format:webp",
                    Price = 13000,
                    Discount = 0.05,
                    CategoryId = 1
                },
                new Product
                {
                    ID = 4,
                    Name = "Oppo Reno 5",
                    ImageUrl = "https://productimages.hepsiburada.net/s/73/222-222/110000014912740.jpg/format:webp",
                    Price = 13000,
                    Discount = 0.05,
                    CategoryId = 1
                }, new Product
                {
                    ID = 5,
                    Name = "Samsung A52",
                    ImageUrl = "https://productimages.hepsiburada.net/s/79/222-222/110000021519477.jpg/format:webp",
                    Price = 13000,
                    Discount = 0.05,
                    CategoryId = 1
                },
                new Product
                {
                    ID = 6,
                    Name = "MSİ Gaming",
                    ImageUrl = "https://productimages.hepsiburada.net/s/131/222-222/110000082171384.jpg/format:webp",
                    Price = 13000,
                    Discount = 0.05,
                    CategoryId = 2
                },
                new Product
                {
                    ID = 7,
                    Name = "Macbook Air M1",
                    ImageUrl = "https://productimages.hepsiburada.net/s/49/222-222/10983950254130.jpg/format:webp",
                    Price = 13000,
                    Discount = 0.05,
                    CategoryId = 2
                },
                new Product
                {
                    ID = 8,
                    Name = "Thinkpad X1",
                    ImageUrl = "https://productimages.hepsiburada.net/s/77/222-222/110000018961471.jpg/format:webp",
                    Price = 13000,
                    Discount = 0.05,
                    CategoryId = 2
                },
                new Product
                {
                    ID = 9,
                    Name = "Dell XPS 15",
                    ImageUrl = "https://productimages.hepsiburada.net/s/42/222-222/10740711587890.jpg/format:webp",
                    Price = 13000,
                    Discount = 0.05,
                    CategoryId = 2
                }, new Product
                {
                    ID = 10,
                    Name = "Huawei Matebook D15",
                    ImageUrl = "https://productimages.hepsiburada.net/s/176/222-222/110000140392350.jpg/format:webp",
                    Price = 13000,
                    Discount = 0.05
                },
                new Product
                {
                    ID = 11,
                    Name = "Macbook Air M1",
                    ImageUrl = "https://productimages.hepsiburada.net/s/49/222-222/10983950254130.jpg/format:webp",
                    Price = 13000,
                    Discount = 0.05,
                    CategoryId = 2
                },
                new Product
                {
                    ID = 12,
                    Name = "Thinkpad X1",
                    ImageUrl = "https://productimages.hepsiburada.net/s/77/222-222/110000018961471.jpg/format:webp",
                    Price = 13000,
                    Discount = 0.05,
                    CategoryId = 2
                }
                );
        }
    }
}
