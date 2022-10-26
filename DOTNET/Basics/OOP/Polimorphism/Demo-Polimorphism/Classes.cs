public class Parent
{
    public int P1 { get; set; }
    public void M1() => Console.WriteLine("Parent M1");
    public virtual void M2() => Console.WriteLine("Parent M2");
}
public class Derived1 : Parent
{
    public override void M2() => Console.WriteLine("Derived1 M2");
    public void M3() => Console.WriteLine("Derived1 M3");
}
public class Derived2 : Parent
{
    public void M1() => Console.WriteLine("Derived2 M1");
    public virtual void M2() => Console.WriteLine("Derived2 M2");
}