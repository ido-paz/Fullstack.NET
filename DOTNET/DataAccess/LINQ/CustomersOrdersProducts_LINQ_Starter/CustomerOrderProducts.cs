using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Shop_LINQ
{
    public class CustomerOrderProducts
    {
        public int CustomerID { get; set; }
        public int OrderID { get; set; }
        public DateTime Created { get; set; }
        public List<OrderProduct> OrderProducts { get; set; }

        public override string ToString() => $"CustomerID={CustomerID},OrderID={OrderID},Products count={(OrderProducts==null ? 0 : OrderProducts.Count)}";

    }
}
