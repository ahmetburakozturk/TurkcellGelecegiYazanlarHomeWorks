using BootShop.DataAccess.Repository;
using BootShop.Entities;
using System.Collections.Generic;

namespace BootShop.Businness
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;


        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ICollection<Product> GetProducts()
        {
            return _productRepository.GetAll();
        }
    }
}
