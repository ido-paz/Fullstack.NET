
namespace Vehical
{
    interface EngineState
    {
        void Start();
        void Stop();
    }
    public class Motorcycle : EngineState
    {
        public NumberOfWheels NumberOfWheels = NumberOfWheels.Two;
        public FuelType FuelType;

        public void Start() { System.Console.WriteLine("Starting motorcycle"); }
        public void Stop() { System.Console.WriteLine("Stop motorcycle"); }

    }

    public class Car : EngineState
    {
        public NumberOfWheels NumberOfWheels = NumberOfWheels.Four;
        public FuelType FuelType;

        public void Start() { System.Console.WriteLine("Starting Car"); }
        public void Stop() { System.Console.WriteLine("Stop Car"); }

    }
    public enum NumberOfWheels
    {
        Two = 2,
        Four = 4,
        Six = 6
    }

    public enum FuelType
    {
        Gas,
        Gasoline,
        Diesel,
        Electric
    }
}