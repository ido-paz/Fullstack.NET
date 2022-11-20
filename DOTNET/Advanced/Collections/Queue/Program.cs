using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<User> users = new Queue<User>();
        //
        users.Enqueue(new User() { ID = 1, Name = "Ido" });
        users.Enqueue(new User() { ID = 2, Name = "David" });
        users.Enqueue(new User() { ID = 3, Name = "Avi" });
        //
        User user = users.Dequeue();
        users.Dequeue();
        //
        int a = Calc();
        Calc();
    }

    static int Calc()
    {
        return 1;
    }
}

class User
{
    public int ID { get; set; }
    public string Name { get; set; }
}