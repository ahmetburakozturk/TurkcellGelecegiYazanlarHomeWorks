using BootShop.Entities;
using System.Collections.Generic;

namespace BootShop.Businness
{
    public class FakeCategoryService : ICategoryService
    {
        public List<Category> categories;
        public FakeCategoryService()
        {
            categories = new List<Category>
            {
                new Category{ID = 1, Name = "Bilgisayar"},
                new Category{ID = 2, Name = "Tablet"},
                new Category{ID = 3, Name = "Telefon"},
                new Category{ID = 4, Name = "Mobilya"},
                new Category{ID = 5, Name = "Giysi"}
            };
        }

        public List<Category> GetCategories()
        {
            return categories;
        }
    }
}
