public delegate void D1();
public delegate int D2();
public delegate int D3(int a);

class Program
{
    static void Main()
    {
        // D1 d1 = new D1(F1);
        // d1 += F11;
        // d1 -= F11;
        // d1 -= F11;
        // //
        // d1();

        // D2 d2 = F2;
        // System.Console.WriteLine(d2.Invoke());

        D3 d3 = F3;
        System.Console.WriteLine(d3.Invoke(333));
    }

    static void F1()
    {
        System.Console.WriteLine("F1");
    }

    static void F11()
    {
        System.Console.WriteLine("F11");
    }

    static int F2()
    {
        return 2;
    }

    static int F3(int a)
    {
        return a;
    }

    static int IsEven(int number)
    {
        return a;
    }
}