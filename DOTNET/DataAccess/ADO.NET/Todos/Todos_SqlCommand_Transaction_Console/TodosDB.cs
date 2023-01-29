
public class TodosDB : IItemsCRUD
{

    public TodosDB(string connectionString)
    {
    }

    public int DeleteItem(Item item)
    {
        throw new NotImplementedException();
    }

    public int DeleteItem(int id)
    {
        throw new NotImplementedException();
    }

    public int DeleteItem(string title)
    {
       throw new NotImplementedException();
    }

    public IEnumerable<Item> GetAllItems()
    {
       throw new NotImplementedException();
    }

    public Item GetItem(string title)
    {
       throw new NotImplementedException();
    }

    public int InsertItem(Item item)
    {
        throw new NotImplementedException();
    }

    public int UpdateItem(Item item)
    {
       throw new NotImplementedException();
    }
}