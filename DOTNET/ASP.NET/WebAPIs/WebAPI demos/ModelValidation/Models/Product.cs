using System.ComponentModel.DataAnnotations;

public class Product
{
    [Range(1, 1234567)]
    public int Id { get; set; }

    [MinLength(2)]
    [MaxLength(12)]
    public string Name { get; set; }

    [Range(1,1234)]
    public decimal Price { get; set; }

    public override string ToString()
    {
        return $"{Id},{Name},{Price}";
    }
}
