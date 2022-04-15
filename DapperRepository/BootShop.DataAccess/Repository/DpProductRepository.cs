using BootShop.Entities;
using Dapper;
using Npgsql;
using System.Collections.Generic;
using System.Linq;

namespace BootShop.DataAccess.Repository
{
    public class DpProductRepository : IProductRepository
    {
        private NpgsqlConnection _connection =
            new NpgsqlConnection("User ID =postgres;Password=Pa$$w0rd!.;Server=localhost;Port=5432;Database=BootShopDb;Integrated Security = true; Pooling = true;");
        private string _sqlConn =
            "User ID =postgres;Password=Pa$$w0rd!.;Server=localhost;Port=5432;Database=BootShopDb;Integrated Security = true; Pooling = true;";


        public IList<Product> GetAll()
        {
            using (_connection)
            {
                var getAllQuery = "SELECT * FROM public.\"Products\"";
                var productList = _connection.Query<Product>(getAllQuery).ToList();
                return productList;
            }
        }

        public Product GetById(int id)
        {
            string productQuery = "SELECT * FROM public.\"Products\" WHERE ID = @ProductID;";
            using (var connection = new NpgsqlConnection(_sqlConn))
            {
                var product = connection.QueryFirstOrDefault<Product>(productQuery, id);
                return product;
            }
        }

        public int Add(Product entity)
        {
            using (_connection)
            {
                var getAllQuery = "SELECT * FROM public.\"Products\" ([ID],[Name],[Description],[ImageUrl],[CategoryId]) VALUES (@ID, @Name, @Descriptipn, @ImageUrl, @CategoryId)";
                var affectedRows = _connection.Execute(getAllQuery, new { entity.ID, entity.Name, entity.Description, entity.ImageUrl, entity.CategoryId });
            }

            return entity.ID;
        }

        public int Update(Product entity)
        {
            using (_connection)
            {
                var updateQuery = "UPDATE public.\"Products\"  SET ([ID],[Name],[Description],[ImageUrl],[CategoryId]) VALUES (@ID, @Name, @Descriptipn, @ImageUrl, @CategoryId)";
                var res = _connection.Execute(updateQuery, new { entity.ID, entity.Name, entity.Description, entity.ImageUrl, entity.CategoryId });
            }

            return entity.ID;
        }

        public void Delete(int id)
        {
            using (_connection)
            {
                var deleteQuery = "DELETE FROM public.\"Products\" WHERE ID=@ID";
                var res = _connection.Execute(deleteQuery, new { ID = id });
            }
        }
    }
}
