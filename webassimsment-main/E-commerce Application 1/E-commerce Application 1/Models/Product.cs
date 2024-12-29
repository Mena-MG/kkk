namespace E_commerce_Application_1.Models
{
    public class Products
    {
        public int ProductsID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int StockQuantity { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}
