// See https://aka.ms/new-console-template for more information
try
{
    Console.WriteLine("Hello, Israel!");
    throw new AUException("mY AU");
    throw new Exception("My e");
    Console.WriteLine("Hello, HackerU!");
}
catch(AUException au){
    System.Console.WriteLine("AUException:" + au.Message);
}
catch (System.Exception e)
{
    System.Console.WriteLine("Exception:" + e.Message);
}
//
public class AUException : System.Exception
{
    public AUException() { }
    public AUException(string message) : base(message) { }
    public AUException(string message, System.Exception inner) : base(message, inner) { }
    protected AUException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}