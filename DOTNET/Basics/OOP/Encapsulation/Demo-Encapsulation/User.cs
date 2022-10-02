public class User
{
    static int count;
    public string UserName;
    public string Password;
    private DateTime created;
    public DateTime Created
    {
        get
        {
            return created;
        }
        private set
        {
            created = value;
        }
    }
    public User() : this(null,null) 
    { 

    }
    public User(string userName, string password)
    {
        UserName = userName;
        Password = password;
        Created = DateTime.Now;
        User.count++;
    }
    //
    public string GetDetails()
    {
        return $"{UserName},{Password},{Created}";
    }
    //
    public static int GetCount()
    {
        return User.count;
    }
    //
}