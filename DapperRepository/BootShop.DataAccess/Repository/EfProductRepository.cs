using BootShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BootShop.DataAccess.Repository
{
    public class EfProductRepository : IProductRepository
    {
        private readonly bootShopDbContext _context;

        public EfProductRepository(bootShopDbContext contex)
        {
            _context = contex;
        }

        public IList<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Add(Product entity)
        {
            _context.Products.Add(entity);
            _context.SaveChanges();
            return entity.ID;
        }

        public int Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
