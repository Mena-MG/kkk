namespace E_commerce_Application_1.Models
{
    public class Customers
    {
        public int CustomersID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }
}
