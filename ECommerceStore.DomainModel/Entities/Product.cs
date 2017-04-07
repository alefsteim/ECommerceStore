using System.ComponentModel.DataAnnotations;

namespace ECommerceStore.DataAccess
{
    public class Product
    {
        public int ProductID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public double Price { get; set; }
    }
}