using System.Diagnostics;

class Program
{
    static Dictionary<int, int> FromTo = new Dictionary<int, int>()
    { { 1, 33333 }, { 33333, 66666 }, { 66666, 99999 } , { 99999, 121212 }  };
    //
    static async Task Main()
    {
        Console.Clear();
        //
        PrintPrimes_SYNC();
        Console.WriteLine("****************");
        await PrintPrimes_ASYNC();
        Console.WriteLine("****************"); 
        PrintPrimes_Task();
        Console.WriteLine("****************"); 
        PrintPrimes_ParallelForEach();
        Console.WriteLine("****************"); 
        PrintPrimes_ParallelFor();
        Console.WriteLine("****************"); 
        PrintPrimes_ParallelInvoke();
    }
    //
    static async Task PrintPrimes_ASYNC()
    {
        Console.WriteLine("PrintPrimes_ASYNC:");
        Stopwatch sw = Stopwatch.StartNew();
        await Task.Run(() => { });
        sw.Stop();
        Console.WriteLine($"All calculations took {sw.ElapsedMilliseconds} ms");
    }
    //
    static void PrintPrimes_ParallelInvoke()
    {
        Console.WriteLine("PrintPrimes_ParallelInvoke:");
        Stopwatch sw = Stopwatch.StartNew();
        sw.Stop();
        Console.WriteLine($"All calculations took {sw.ElapsedMilliseconds} ms");
    }
    //
    static void PrintPrimes_ParallelFor()
    {
        Console.WriteLine("PrintPrimes_ParallelFor:");
        Stopwatch sw = Stopwatch.StartNew();
        sw.Stop();
        Console.WriteLine($"All calculations took {sw.ElapsedMilliseconds} ms");
    }
    //
    static void PrintPrimes_ParallelForEach()
    {
        Console.WriteLine("PrintPrimes_ParallelForEach:");
        Stopwatch sw = Stopwatch.StartNew();
        sw.Stop();
        Console.WriteLine($"All calculations took {sw.ElapsedMilliseconds} ms");
    }
    //
    static void PrintPrimes_Task()
    {
        Console.WriteLine("PrintPrimes_ASYNC:");
        Stopwatch sw = Stopwatch.StartNew();
        sw.Stop();
        Console.WriteLine($"All calculations took {sw.ElapsedMilliseconds} ms");
    }

    static void PrintPrimes_SYNC()
    {
        Console.WriteLine("PrintPrimes_SYNC:");
        Stopwatch sw = Stopwatch.StartNew();
        foreach (var kv in FromTo)
        {
            PrintPrimesInRange(kv.Key, kv.Value);
        }
        sw.Stop();
        Console.WriteLine($"All calculations took {sw.ElapsedMilliseconds} ms");
    }

    static void PrintPrimesInRange(int start, int end)
    {
        Primes primes = new Primes(start, end);
        Console.WriteLine($"Start={primes.Start},End={primes.End},Count={primes.CountPrimes()}, CalculationDurationMS = {primes.CalculationDurationMS}");
    }
}
