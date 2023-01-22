public interface IItemsCRUD
{
    #region Read / Get
    public IEnumerable<Item> GetAllItems();
    public Item GetItem(string title);
    #endregion

    #region Update 
    public int UpdateItem(Item item);
    #endregion

    #region Create / Add / Insert
    public int InsertItem(Item item);
    #endregion

    #region Remove / Delete
    public int DeleteItem(Item item);
    public int DeleteItem(int id);
    public int DeleteItem(string title);
    #endregion

}
