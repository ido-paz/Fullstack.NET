namespace Shop_FC_Summery.Models
{
    public class ProductOrder
    {
        public int OrderId { get; set; }
        public UserOrder UserOrder{ get; set; }

        public int ProductId { get; set; }
        public Product Product{ get; set; }

        public int Quantity { get; set; }
    }
}