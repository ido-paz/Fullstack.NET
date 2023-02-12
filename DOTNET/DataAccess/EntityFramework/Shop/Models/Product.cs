namespace Shop_FC_Summery.Models
{
    public class Product
    {
        public int ProductId { get; set; } 
        public string Name { get; set; }
        public decimal Price { get; set; }

        public ICollection<ProductOrder> ProductsOrders { get; set; }
    }
}