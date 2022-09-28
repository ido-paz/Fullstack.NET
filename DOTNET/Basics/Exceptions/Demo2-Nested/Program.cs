Console.WriteLine("Main start");
try
{
     F1();
     F3();
     F2();
}
catch (System.Exception e)
{
    Console.WriteLine($"Main function exception catch {e.Message}");
}
Console.WriteLine("Main end");
///////////////////////////////
void F1()
{
   Console.WriteLine("f1");
}
//
void F2()
{
    Console.WriteLine("f2 start");
    int[] a = {2,4,5};
    Console.WriteLine(a[444]);
    Console.WriteLine("f2 end");
}
//
void F3(){
    try
    {
        Console.WriteLine("f3 start try");
        int[] a = {2,4,5};
        Console.WriteLine(a[444]);
        Console.WriteLine("f3 end try");
    }
    catch (System.Exception e)
    {
        Console.WriteLine("f3 exception");
    }
}