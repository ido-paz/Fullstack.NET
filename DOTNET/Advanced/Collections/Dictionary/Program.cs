using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Dictionary<int,string> students = new Dictionary<int, string>();
        students.Add(1234,"Ido");
        students.Add(3333,"Kelly");
        students.Add(3242,"Misha");
        //
        bool removed = students.Remove(3242); 
        bool contains = students.ContainsKey(777);
        //
        foreach (var item in students)
        {
            System.Console.WriteLine($"{item.Key}:{item.Value}");
        }
    }
}