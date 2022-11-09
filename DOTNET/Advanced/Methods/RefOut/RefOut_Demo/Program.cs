using System;
class Program
{
    static void Main()
    {
        int a = Tools.F1(), b = 2;
        string s = "pita";
        //
        Console.WriteLine($"Original : {a},{b},{s}");
        Tools.M1(a, b, s);
        Console.WriteLine($"After M1 : {a},{b},{s}");
        Tools.M2(ref a, ref b, ref s);
        Console.WriteLine($"After M2 : {a},{b},{s}");
        Tools.M3(out a, out b, out s);
        Console.WriteLine($"After M2 : {a},{b},{s}");
        Tools.M4(a, b, s);
        Console.WriteLine($"After M2 : {a},{b},{s}");
    }
}
