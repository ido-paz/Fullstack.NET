try{
    Console.WriteLine("t1");
    throw new ApplicationException("error");
}
catch(ArgumentException ae ){
    Console.WriteLine("c1 " + ae.Message);
}
catch (Exception e)
{
    Console.WriteLine("c1 e");
}
finally{
    Console.WriteLine("f1");
}
Console.WriteLine("af");