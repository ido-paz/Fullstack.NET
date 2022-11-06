using Vehical;
using Food;
class Program
{
    public static void Main()
    {
        Vehical.Motorcycle m1 = new Vehical.Motorcycle();
        Vehical.Car c1 = new Vehical.Car();
        var c2 = new Vehical.Car();
        m1.Start();
        c1.Start();
        c2.Start();
    }

}

