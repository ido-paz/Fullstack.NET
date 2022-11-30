using System;

namespace Shop_LINQ
{
    public class OrderProduct
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int ProductCount { get; set; }
        public override string ToString() => $"OrderID={OrderID},ProductID={ProductID},ProductCount={ProductCount}";

    }
}
