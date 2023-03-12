namespace Services_DI.Models
{
    public class ProductsDB
    {
        List<Product> _Products { get; set; } = new List<Product>()
        {
            new Product(){Id=1,Name="p1",Price=11},
            new Product(){Id=2,Name="p2",Price=22},
            new Product(){Id=3,Name="p3",Price=33},
            new Product(){Id=4,Name="p4",Price=44},
        };

      
    }
}
