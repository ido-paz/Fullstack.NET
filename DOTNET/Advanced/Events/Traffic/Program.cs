using Traffic;
class Program
{
    static void Main()
    {
        TrafficLight tl1 = new TrafficLight() { ID = 1 };
        TrafficLight tl2 = new TrafficLight() { ID = 2 };
        //
        Car c1 = new Car() { Year = 2012, Model = "Subaru" };
        Car c2 = new Car() { Year = 2021, Model = "Mazda" };
        //subscribe
        tl2.OnSwitchedColor += c1.TraficLightColor_Changed;
        tl2.OnSwitchedColor += c2.TraficLightColor_Changed;
        //unsubscribe
        //tl2.OnSwitchedColor -= c2.TraficLightColor_Changed;
        //
        tl2.ChangeLight(TraficLightColor.Green);
    }

    static void TraficLightColor_Changed(TraficLightColor tlc)
    {
        System.Console.WriteLine($"Changed color to {tlc}");
    }

    static void TraficLightColor_Changed2(TraficLightColor tlc)
    {
        System.Console.WriteLine($"Changed color to {tlc}");
    }
}

