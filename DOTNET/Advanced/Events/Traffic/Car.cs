using Traffic;
public class Car
{
    public int Year { get; set; }
    public string Model { get; set; }
    public void TraficLightColor_Changed(TraficLightColor tlc)
    {
        if (tlc == TraficLightColor.Green)
            StartDriving();
        else if (tlc == TraficLightColor.Red)
            StopDriving();
        else
        {

        }
    }
    public void StartDriving() { }
    public void StopDriving() { }
}