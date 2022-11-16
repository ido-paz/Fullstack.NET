namespace Traffic;
public class TrafficLight
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
public enum TraficLightColor
{
    Red,
    Orange,
    Green
}

public delegate void SwitchedColor(TraficLightColor tlc);