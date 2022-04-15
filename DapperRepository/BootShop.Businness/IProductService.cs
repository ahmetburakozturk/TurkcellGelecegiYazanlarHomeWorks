using BootShop.Entities;
using System.Collections.Generic;

namespace BootShop.Businness
{
    public interface IProductService
    {
        ICollection<Product> GetProducts();
    }
}
