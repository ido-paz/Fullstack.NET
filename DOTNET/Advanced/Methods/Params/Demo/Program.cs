class Program
{
    static void Main(params string[] array)
    {
        F2(array);
        // WithParams();
    }

    static void WithParams()
    {
        F2();
        F2(1);
        F2(1, 2);
        F2(1, 2, 3);
        F2(1, 2, 3, 4);
        F2(1, 2, "MOMO", 4, 5);
    }
    static void F2(params object[] array)
    {
        System.Console.WriteLine(string.Join(',', array));
    }
    static void WithoutParams()
    {
        F1();
        F1(1);
        F1(1, 2);
        F1(1, 2, 3);
    }
    static void F1() { }
    static void F1(int i) { }
    static void F1(int i, int z) { }
    static void F1(int i, int z, int y) { }

}