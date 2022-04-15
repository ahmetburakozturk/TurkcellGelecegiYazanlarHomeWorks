using System.Collections.Generic;

namespace BootShop.Entities
{
    public class Category : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
