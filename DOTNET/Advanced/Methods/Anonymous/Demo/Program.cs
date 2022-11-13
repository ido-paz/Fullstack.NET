class Program
{
    static void Main()
    {
        // D1 d1 = new D1(F);
        // D2 d2 = new D2(F2);
        // D3 d3 = new D3(F3);
        D1 d1 = new D1(delegate ()
        {
            System.Console.WriteLine("Anonymous invoked");
        });
        D2 d2 = new D2(delegate (int a)
        {
            System.Console.WriteLine("Anonymous invoked " + a);
        });
        D3 d3 = new D3(delegate (int a)
        {
            System.Console.WriteLine("Anonymous invoked " + a);
            return a;
        });
        // 
        d1();
        d2(2);
        d3(3);
    }

    static void Moshe()
    {
        var d1 = delegate ()
        {
            System.Console.WriteLine("Anonymous invoked");
        };
        d1();
    }
    static void F1()
    {
        System.Console.WriteLine("F1 invoked");
    }

    static void F2(int a)
    {
        System.Console.WriteLine("F2 invoked " + a);
    }

    static int F3(int a)
    {
        System.Console.WriteLine("F3 invoked " + a);
        return a;
    }
}

delegate void D1();

delegate void D2(int a);

delegate int D3(int a);