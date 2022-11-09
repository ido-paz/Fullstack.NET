
public static class Tools
{
    public static void M1(int n1, int n2, string t)
    {
        n1 = 11;
        n2 = 22;
        t = "lafa";
    }
    public static void M2(ref int n1, ref int n2, ref string t)
    {
        n1 = 11;
        n2 = 22;
        t = "lafa";
    }

    public static void M3(out int n1, out int n2, out string t)
    {
        n1 = 111;
        n2 = 222;
        t = "baget";
    }

    public static void M4(in int n1,in int n2, in string t)
    {
        n1 = 111;
        n2 = 222;
        t = "baget";
    }


    public static int F1()
    {
        return 1;
    }
}