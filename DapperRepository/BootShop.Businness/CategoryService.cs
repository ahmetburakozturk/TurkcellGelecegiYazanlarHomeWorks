using BootShop.DataAccess;
using BootShop.Entities;
using System.Collections.Generic;
using System.Linq;

namespace BootShop.Businness
{
    public class CategoryService : ICategoryService
    {
        private readonly bootShopDbContext _dbContext;

        public CategoryService(bootShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Category> GetCategories()
        {
            return _dbContext.Categories.ToList();
        }
    }
}
