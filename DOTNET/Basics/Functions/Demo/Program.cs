class Program
{
    static void Main()
    {
        int z = f2();
        System.Console.WriteLine("*");
        f1(2);
        System.Console.WriteLine("+");
    }
    static void f0()
    {
        int i = 0;
        System.Console.WriteLine("f0");
    }
    static void f1(int a)
    {

        System.Console.WriteLine("f1");
    }
    static int f2()
    {
        f0();
        System.Console.WriteLine("f2");
        return -1;
    }

}