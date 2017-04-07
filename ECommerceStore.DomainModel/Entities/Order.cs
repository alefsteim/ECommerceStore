using System.Collections.Generic;

namespace ECommerceStore.DomainModel.Entities
{
    public class Order
    {
 
        public int OrderID { get; set; }
        //public ICollection<CartLine> Lines { get; set; }
        public string UserId { get; set; }

        public double TotalSum { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string House { get; set; }

        public string Index { get; set; }
        public string Email { get; set; }
        public bool GiftWrap { get; set; }
    }
}