using System;
class Program
{
    static void Main()
    {
        Action a1 = F1;
        Action<int> a2 = F2;
        //
        Func<int> af3= F3;
        Func<int,int> af4 = F4;
        Func<int,string,int> af5 = F5;

    }

    static void F1() { }

    static void F2(int a) { }

    static int F3() { return 3;}

    static int F4(int a) { return 4;}

    static int F5(int a,string s) { return 4;}
}