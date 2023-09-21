using Ecomm.Entity;


namespace Ecomm.Entity
{
    public partial class Customer
    {
        // Add a navigation property to represent the relationship with orders
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}

