namespace Shop_FC_Summery.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string? Password { get; set; }

        public ICollection<UserOrder> UserOrders { get; set; }
    }
}