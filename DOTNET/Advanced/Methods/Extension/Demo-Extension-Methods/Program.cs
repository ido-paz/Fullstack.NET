class Program
{
    static void Main()
    {
        int number1 = 24;
        int number2 = 43;

        System.Console.WriteLine($"{number1} is event {Tools.IsEven(number1)}");
        System.Console.WriteLine($"{number2} is event {number2.IsEven()}");
        System.Console.WriteLine($"{111} is event {(111).IsEven()}");

        // string t1 = "Ido Paz ohev tahini";
        // string t2 = "ohev tahini";
        // string t3 = "tahini";
        // System.Console.WriteLine($"{t1} has {WordCount(t1)} words");
        // System.Console.WriteLine($"{t2} has {Tools.WordCount(t2)} words");
        // System.Console.WriteLine($"{t3} has {t3.WordCount()} words");
    }

    static bool IsEven(int a)
    {
        return a % 2 == 0;
    }
    static int WordCount(string text)
    {
        string[] array = text.Split(' ');
        return array.Length;
    }
}

static class Tools
{
    public static int WordCount(this string text)
    {
        string[] array = text.Split(' ');
        return array.Length;
    }

    public static bool IsEven(this int a)
    {
        return a % 2 == 0;
    }
}