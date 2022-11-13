class Program
{
    static void Main()
    {
        var isEven = (int x) => x % 2 == 0;
        var makePita = (string doughType) =>
        {
            return $"made pita from {doughType}";
        };
        var print = (string message)=> System.Console.WriteLine(message);
        //
        System.Console.WriteLine($"4 is even {isEven(4)}");
        System.Console.WriteLine($"5 is even {isEven(5)}");
        //
        System.Console.WriteLine(makePita("kosmin"));
        //
        print("Mashu mashu");
    }
}