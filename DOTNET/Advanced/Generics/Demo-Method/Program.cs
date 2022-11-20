using System;

public delegate int D(int a);
class Program
{
    static void Main()
    {
        D d = F1;
        Func<int, int> f = F1;
        //
        int r1 = F1(1);
        string r2 = F2("2");
        DateTime r3 = F3(DateTime.Now);
        //
        int r4 = F4<int>(4);
        string r5 = F4<string>("ido");
        DateTime r6 = F4<DateTime>(new DateTime());
        //
        int r4 = F5<int, int>(4, 4);
        string r5 = F5<string, int>("ido", 12);
        DateTime r6 = F5<DateTime, string>(new DateTime(), "PP");
    }

    static int F1(int a) { return a; }

    static string F2(string a) { return a; }

    static DateTime F3(DateTime a) { return a; }

    static T F4<T>(T a) { return a; }

    static T F5<T, Z>(T a, Z b) { return a; }
}