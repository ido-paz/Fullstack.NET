namespace Shop_LINQ
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Email { get; set; }
              
        public override string ToString() => $"{CustomerID},{Email}";
    }
}
