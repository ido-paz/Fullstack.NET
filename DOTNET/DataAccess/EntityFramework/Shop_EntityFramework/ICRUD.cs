public interface ICRUD<T>
{
    #region Read / Get
    public IEnumerable<T> GetAll();
    public T Get(string name);
    #endregion

    #region Update 
    public int Update(T item);
    #endregion

    #region Create / Add / Insert
    public int Insert(T item);
    #endregion

    #region Remove / Delete
    public int Delete(T item);
    public int Delete(int id);
    public int Delete(string name);
    #endregion

}
