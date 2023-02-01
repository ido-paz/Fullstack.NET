using System.Data.Common;
using System.Data.SqlClient;
using System.Transactions;

public class TodosDB : IItemsCRUD
{
    public string ConnectionString { get; set; }

    public TodosDB() { }
    public TodosDB(string connectionString)
    {
        ConnectionString = connectionString;
    }

    #region Items CRUD operations
    public int DeleteItem(Item item)
    {
        return DeleteItem(item.Id);
    }
    public int DeleteItem(int id)
    {
        return DeleteItemNonQuery($"delete from items where Id={id}");
    }
    public int DeleteItem(string title)
    {
        return DeleteItemNonQuery($"delete from items where title='{title}'");
    }

    int DeleteItemNonQuery(string text)
    {
        SqlCommand cmd = new SqlCommand(text);
        using (SqlConnection cn = new SqlConnection(ConnectionString))
        {
            cn.Open();
            cmd.Connection = cn;
            return cmd.ExecuteNonQuery();
        }
    }

    IEnumerable<Item> GetItemsExecuteReader(string text)
    {
        SqlCommand cmd = new SqlCommand(text);
        object[] values = new object[3];
        using (SqlConnection cn = new SqlConnection(ConnectionString))
        {
            cn.Open();
            cmd.Connection = cn;
            using (DbDataReader dr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
            {
                while (dr.Read())
                {
                    dr.GetValues(values);
                    yield return new Item(values);
                }
            }
        }
    }
    //
    public IEnumerable<Item> GetAllItems()
    {
        return GetItemsExecuteReader("select * from items");
    }

    public Item GetItem(string title)
    {
        IEnumerable<Item> items = GetItemsExecuteReader($"select top 1 * from items where title='{title}'");
        return items.FirstOrDefault();
    }

    public int GetMaxItemId()
    {
        object result = null;
        SqlCommand cmd = new SqlCommand("select max(id) from Items");
        using (SqlConnection cn = new SqlConnection(ConnectionString))
        {
            cn.Open();
            cmd.Connection = cn;
            result = cmd.ExecuteScalar();
        }
        if (result == null)
            return 1;
        else
            return ((int)result) + 1;
    }

    public int InsertItem(Item item)
    {
        int isCompleted = item.IsCompleted ? 1 : 0;
        //int id = GetMaxItemId();
        string insertSQL = $"insert into Items values('{item.Title}',{isCompleted})";
        SqlCommand cmd = new SqlCommand(insertSQL);
        using (SqlConnection cn = new SqlConnection(ConnectionString))
        {
            cn.Open();
            cmd.Connection = cn;
            return cmd.ExecuteNonQuery();
        }
    }

    public int InsertItems(List<Item> items)
    {
        int affected = 0;
        using (TransactionScope ts = new TransactionScope()) 
        {
            foreach (var item in items)
            {
                affected += InsertItem(item);
            }
            ts.Complete();
        }
        return affected;
    }

    public int UpdateItem(Item item)
    {
        int isCompleted = item.IsCompleted ? 1 : 0;
        string insertSQL = $"update Items set title='{item.Title}',isCompleted={isCompleted} where id={item.Id}";
        SqlCommand cmd = new SqlCommand(insertSQL);
        using (SqlConnection cn = new SqlConnection(ConnectionString))
        {
            cn.Open();
            cmd.Connection = cn;
            return cmd.ExecuteNonQuery();
        }
    }

    #endregion
}
