class Program
{
    static void Main()
    {
        TrafficLight tl1 = new TrafficLight() { ID = 1 };
        TrafficLight tl2 = new TrafficLight() { ID = 2 };
        //
        System.Console.WriteLine("Before change");
        System.Console.WriteLine(tl1.GetDetails());
        System.Console.WriteLine(tl2.GetDetails());
        //
        tl1.OnSwitchedColor += TraficLightColor_Changed;
        tl1.OnSwitchedColor += TraficLightColor_Changed2;
        tl1.OnSwitchedColor -= TraficLightColor_Changed;
        //
        tl1.ChangeLight(TraficLightColor.Orange);
        tl2.ChangeLight(TraficLightColor.Orange);
        System.Console.WriteLine("After change");
        System.Console.WriteLine(tl1.GetDetails());
        System.Console.WriteLine(tl2.GetDetails());
    }

    static void TraficLightColor_Changed(TraficLightColor tlc){
        System.Console.WriteLine($"Changed color to {tlc}");
    }

    static void TraficLightColor_Changed2(TraficLightColor tlc){
        System.Console.WriteLine($"Changed color to {tlc}");
    }
}

enum TraficLightColor
{
    Red,
    Orange,
    Green
}
class TrafficLight
{
    public int ID { get; set; }
    TraficLightColor _TraficLightColor = TraficLightColor.Red;
    public event SwitchedColor OnSwitchedColor;
    public void ChangeLight(TraficLightColor tlc)
    {
        _TraficLightColor = tlc;
        if (OnSwitchedColor != null) OnSwitchedColor(tlc);
    }
    public string GetDetails()
    {
        return $"{ID},{_TraficLightColor}";
    }
}

delegate void SwitchedColor(TraficLightColor tlc);