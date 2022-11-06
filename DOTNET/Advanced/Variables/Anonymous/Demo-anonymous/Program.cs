class Program
{
    static void Main()
    {
        var user1 = new
        {
            Id = 1,
            Name = "Ido",
            Password = "1234"
        };

        var user2 = new User()
        {
            Name = "Ido",
            Password = "1234"
        };

        var user3 = new
        {
            Id = 1,
            Name = "Ido",
            Password = "1234",
            Gender = "Male"
        };
        System.Console.WriteLine($"{user1.Name},{user1.Password},{user1.GetType().Name}");
        System.Console.WriteLine($"{user2.Name},{user2.Password},{user2.GetType().Name}");

    }
}

class User
{
    public string Name { get; set; }
    public string Password { get; set; }
}