using System.ComponentModel.DataAnnotations;

namespace ECommerceStore.DomainModel.Entities
{
    public class Product
    {
        public int ProductID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }
    }
}