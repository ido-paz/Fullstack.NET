using System.Text.Json;
using System.IO;
class Program
{
    static void Main()
    {
        string fn = "users.json";
        string text = File.ReadAllText(fn);
        List<User> users= JsonSerializer.Deserialize<List<User>>(text);

        foreach (var item in users)
        {
            System.Console.WriteLine(item);
        }
        //System.Console.WriteLine(u1.Name);
        // List<User> users = new List<User>()
        // {
        //     new User() { ID = 1, Name = "Ido" } ,
        //     new User() { ID = 2, Name = "Moti" } ,
        //     new User() { ID = 3, Name = "Anna" }
        // };
        // //
        // string text = JsonSerializer.Serialize(users);
        // File.WriteAllText(fn, text);

    }
}

class User
{
    public int ID { get; set; }
    public string Name { get; set; }
    public DateTime Created { get; set; }

    public override string ToString()
    {
        return $"{ID},{Name}";
    }
}