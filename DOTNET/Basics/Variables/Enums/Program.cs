
public enum Power
{
    On,
    Off
}
class Program
{
    static void Main()
    {
        Power on = Power.On;
        PrintPower(on);
        PrintPower(Power.On);
        PrintPower(Power.Off);
    }

    static void PrintPower(Power power)
    {
        if (power == Power.On) System.Console.WriteLine("Power is On = " + (int)power);
        else if (power == Power.Off) System.Console.WriteLine("Power is Off = " + (int)power);
    }
}