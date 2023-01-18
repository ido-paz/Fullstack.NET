public class Item
{
    public int Id { get; set; }
    public string Title { get; set; }
    public bool IsCompleted { get; set; }

    public Item(){}
    public Item(object[] values)
    {
        if (values != null)
        {
            if (values.Length == 3)
            {
                Id = (int)values[0];
                Title = values[1].ToString();
                IsCompleted = (bool)values[2];
            }
        }
    }


    public override string ToString()
    {
        return $"{Id},{Title},{IsCompleted}";
    }
}
