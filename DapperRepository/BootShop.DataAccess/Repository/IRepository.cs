using BootShop.Entities;
using System.Collections.Generic;

namespace BootShop.DataAccess.Repository
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        IList<T> GetAll();
        T GetById(int id);
        int Add(T entity);
        int Update(T entity);
        void Delete(int id);
    }
}
