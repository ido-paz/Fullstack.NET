using System.IO;
using System;
class Program
{
    static void Main()
    {
        string fileName = @"c:\users\ido_p\downloads\data.txt";

        if (File.Exists(fileName))
        {
            System.Console.WriteLine("Enter something to add to file:");
            File.AppendAllText(fileName, Console.ReadLine());
        }
        else
        {
            System.Console.WriteLine("Enter something to write to file:");
            File.WriteAllText(fileName, Console.ReadLine());
        }

    }
}