class Program
{
    static void Main()
    {
        dynamic d1 = 1;
        // bool b = false;
        // b.ToUpper();
        System.Console.WriteLine(d1);
        d1 = "mashu";
        System.Console.WriteLine(d1);
        d1 = false;
        Print(d1.ToUpper());
    }

    static void Print(dynamic d){
        System.Console.WriteLine(d);
    }
}