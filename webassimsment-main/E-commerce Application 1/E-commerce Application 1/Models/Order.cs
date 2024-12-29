using System.ComponentModel.DataAnnotations.Schema;

namespace E_commerce_Application_1.Models
{
    public class Orders
    {
        public int OrdersID { get; set; }
        public int CustomerID { get; set; }
        [ForeignKey("CustomerID")] 
        public Customers Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
