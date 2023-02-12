namespace Shop_FC_Summery.Models
{
    public class UserOrder
    {
        public int OrderId { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public DateTime Created { get; set; }    

        public ICollection<ProductOrder> ProductsOrder { get; set; }
    }
}