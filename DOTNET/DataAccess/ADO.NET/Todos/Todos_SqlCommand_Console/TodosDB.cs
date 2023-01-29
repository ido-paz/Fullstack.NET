using Microsoft.Data.SqlClient;
using System.Data.Common;

public class TodosDB : IItemsCRUD
{
    private string ConnectionString;

    public TodosDB(string connectionString)
    {
        ConnectionString = connectionString;
    }

    public int DeleteItem(Item item)
    {
        return DeleteItem(item.Id);
    }

    public int DeleteItem(int id)
    {
        using (SqlConnection cn = new SqlConnection(ConnectionString))
        {
            int affectedRows = 0;
            SqlCommand cmd = new SqlCommand($"delete from items where id={id}", cn);
            cn.Open();
            affectedRows = cmd.ExecuteNonQuery();
            return affectedRows;
        }
    }

    public int DeleteItem(string title)
    {
        using (SqlConnection cn = new SqlConnection(ConnectionString))
        {
            int affectedRows = 0;
            SqlCommand cmd = new SqlCommand($"delete from items where title='{title}'", cn);
            cn.Open();
            affectedRows = cmd.ExecuteNonQuery();
            return affectedRows;
        }
    }

    public IEnumerable<Item> GetAllItems()
    {
        using (SqlConnection cn = new SqlConnection(ConnectionString))
        {
            int affectedRows = 0;
            SqlCommand cmd = new SqlCommand($"select * from items", cn);
            object[] values = new object[3];
            cn.Open();
            using (DbDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    rdr.GetValues(values);
                    yield return new Item(values);
                }
            }
        }
    }

    public Item GetItem(string title)
    {
        using (SqlConnection cn = new SqlConnection(ConnectionString))
        {
            int affectedRows = 0;
            SqlCommand cmd = new SqlCommand($"select * from items where title='{title}'", cn);
            object[] values = new object[2];
            cn.Open();
            using (DbDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    rdr.GetValues(values);
                    return new Item(values);
                }

            }
        }
        return null;
    }

    public int InsertItem(Item item)
    {
        using (SqlConnection cn = new SqlConnection(ConnectionString))
        {
            int isCompleted = item.IsCompleted ? 1 : 0;
            int affectedRows = 0;
            //SqlCommand cmd = new SqlCommand($"insert into items values('{item.Title}',{isCompleted})", cn);
            SqlCommand cmd = new SqlCommand("InsertItem", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@title", item.Title);
            cmd.Parameters.AddWithValue("@isCompleted", item.IsCompleted);
            cn.Open();
            affectedRows = cmd.ExecuteNonQuery();
            return affectedRows;
        }
    }

    public int UpdateItem(Item item)
    {
        using (SqlConnection cn = new SqlConnection(ConnectionString))
        {
            int isCompleted = item.IsCompleted ? 1 : 0;
            int affectedRows = 0;
            SqlCommand cmd = new SqlCommand($"update items set title='{item.Title}',isCompleted={isCompleted} where id='{item.Id}'", cn);
            cn.Open();
            affectedRows = cmd.ExecuteNonQuery();
            return affectedRows;
        }
    }
}