class Program
{
    static void Main()
    {
        Animal[] animals = new Animal[]
        {
            new Dog(),
            new Snake(),
            new Dog()
        };
        //
        foreach (var animal in animals)
        {
            animal.Sleep();
            animal.MakeSound();
        }
    }
}
abstract class Animal
{
    public void Sleep()
    {
        System.Console.WriteLine("Sleeping");
    }
    public abstract void MakeSound();
}
class Dog : Animal
{
    public override void MakeSound()
    {
        System.Console.WriteLine("Woof");
    }
}
class Snake : Animal
{
    public override void MakeSound()
    {
        System.Console.WriteLine("PSSS");
    }
}