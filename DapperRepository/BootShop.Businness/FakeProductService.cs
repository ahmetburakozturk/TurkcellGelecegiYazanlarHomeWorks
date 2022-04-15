using BootShop.Entities;
using System.Collections.Generic;

namespace BootShop.Businness
{
    public class FakeProductService : IProductService
    {
        private List<Product> products;

        public FakeProductService()
        {
            products = new List<Product>
            {
                new Product{ID = 1,Name ="Macbook Air M1", CategoryId = 1, Description = "M1 Macbook Air 8 GB Ram 256 GB Ssd",
                    Price = 18500, Discount = 0.10, ImageUrl = "https://cdn.dsmcdn.com//ty237/product/media/images/20211110/21/174187204/117920493/1/1_org.jpg"},
                new Product{ID = 2,Name ="Thinkpad X1 Carbon 8th", CategoryId = 1, Description = "M1 Macbook Air 8 GB Ram 256 GB Ssd",
                Price = 18500, Discount = 0.10, ImageUrl = "https://cdn.dsmcdn.com//ty237/product/media/images/20211110/21/174187204/117920493/1/1_org.jpg"},
                new Product{ID = 3,Name ="MSI Modern 14", CategoryId = 1, Description = "M1 Macbook Air 8 GB Ram 256 GB Ssd",
                Price = 18500, Discount = 0.10, ImageUrl = "https://cdn.dsmcdn.com//ty237/product/media/images/20211110/21/174187204/117920493/1/1_org.jpg"},
                new Product{ID = 4,Name ="Macbook Air M1", CategoryId = 1, Description = "M1 Macbook Air 8 GB Ram 256 GB Ssd",
                    Price = 18500, Discount = 0.10, ImageUrl = "https://cdn.dsmcdn.com//ty237/product/media/images/20211110/21/174187204/117920493/1/1_org.jpg"},
                new Product{ID = 5,Name ="Thinkpad X1 Carbon 8th", CategoryId = 1, Description = "M1 Macbook Air 8 GB Ram 256 GB Ssd",
                    Price = 18500, Discount = 0.10, ImageUrl = "https://cdn.dsmcdn.com//ty237/product/media/images/20211110/21/174187204/117920493/1/1_org.jpg"},
                new Product{ID = 6,Name ="MSI Modern 14", CategoryId = 1, Description = "M1 Macbook Air 8 GB Ram 256 GB Ssd",
                    Price = 18500, Discount = 0.10, ImageUrl = "https://cdn.dsmcdn.com//ty237/product/media/images/20211110/21/174187204/117920493/1/1_org.jpg"},
                new Product{ID = 7,Name ="Macbook Air M1", CategoryId = 1, Description = "M1 Macbook Air 8 GB Ram 256 GB Ssd",
                    Price = 18500, Discount = 0.10, ImageUrl = "https://cdn.dsmcdn.com//ty237/product/media/images/20211110/21/174187204/117920493/1/1_org.jpg"},
                new Product{ID = 8,Name ="İphone 11", CategoryId = 3, Description = "M1 Macbook Air 8 GB Ram 256 GB Ssd",
                    Price = 18500, Discount = 0.10, ImageUrl = "https://cdn.dsmcdn.com//ty237/product/media/images/20211110/21/174187204/117920493/1/1_org.jpg"},
                new Product{ID = 9,Name ="İphone 11", CategoryId = 3, Description = "M1 Macbook Air 8 GB Ram 256 GB Ssd",
                Price = 18500, Discount = 0.10, ImageUrl = "https://cdn.dsmcdn.com//ty237/product/media/images/20211110/21/174187204/117920493/1/1_org.jpg"},
                new Product{ID = 10,Name ="İphone 11", CategoryId = 3, Description = "M1 Macbook Air 8 GB Ram 256 GB Ssd",
                Price = 18500, Discount = 0.10, ImageUrl = "https://cdn.dsmcdn.com//ty237/product/media/images/20211110/21/174187204/117920493/1/1_org.jpg"},
                new Product{ID = 11,Name ="İphone 11", CategoryId = 3, Description = "M1 Macbook Air 8 GB Ram 256 GB Ssd",
                    Price = 18500, Discount = 0.10, ImageUrl = "https://cdn.dsmcdn.com//ty237/product/media/images/20211110/21/174187204/117920493/1/1_org.jpg"},
                new Product{ID = 12,Name ="İphone 11", CategoryId = 3, Description = "M1 Macbook Air 8 GB Ram 256 GB Ssd",
                    Price = 18500, Discount = 0.10, ImageUrl = "https://cdn.dsmcdn.com//ty237/product/media/images/20211110/21/174187204/117920493/1/1_org.jpg"},
                new Product{ID = 13,Name ="İpad Pro 4", CategoryId = 2, Description = "M1 Macbook Air 8 GB Ram 256 GB Ssd",
                    Price = 18500, Discount = 0.10, ImageUrl = "https://cdn.dsmcdn.com//ty237/product/media/images/20211110/21/174187204/117920493/1/1_org.jpg"},
                new Product{ID = 14,Name ="İpad Pro 4", CategoryId = 2, Description = "M1 Macbook Air 8 GB Ram 256 GB Ssd",
                    Price = 18500, Discount = 0.10, ImageUrl = "https://cdn.dsmcdn.com//ty237/product/media/images/20211110/21/174187204/117920493/1/1_org.jpg"}

            };
        }
        public ICollection<Product> GetProducts()
        {
            return products;
        }


    }
}
