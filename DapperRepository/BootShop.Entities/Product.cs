using System;
using System.ComponentModel.DataAnnotations;

namespace BootShop.Entities
{
    public class Product : IEntity
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please Enter a Poduct Name!")]
        public string Name { get; set; }
        public double? Price { get; set; }
        public double? Discount { get; set; }
        public string Description { get; set; }
        public int? CategoryId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ImageUrl { get; set; }

        public Category Category { get; set; }

    }
}
