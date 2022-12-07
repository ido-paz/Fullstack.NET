
using System.Diagnostics;

class Primes
{
    public int Start { get; private set; }
    public int End { get; private set; }
    int[] primes;
    public long CalculationDurationMS { get; private set; }

    public Primes() { }
    public Primes(int start, int end)
    {
        Start = start;
        End = end;
        primes = GetPrimesInRange(start, end);
    }
    //
    public int CountPrimes()
    {
        if (primes == null || primes.Length == 0)
            return 0;
        return primes.Length;
    }
    //
    public int[] GetPrimes()
    {
        return primes;
    }
    //
    public int[] GetPrimesInRange(int start, int end)
    {
        Stopwatch sw = Stopwatch.StartNew();
        int current, count;
        List<int> primes = new List<int>();
        for (current = start; current <= end; current++)
        {
            count = 0;
            for (int i = 2; i <= current / 2; i++)
            {
                if (current % i == 0)
                {
                    count++;
                    break;
                }
            }
            if (count == 0 && current != 1)
                primes.Add(current);
        }
        sw.Stop();
        CalculationDurationMS = sw.ElapsedMilliseconds;
        return primes.ToArray();
    }
}