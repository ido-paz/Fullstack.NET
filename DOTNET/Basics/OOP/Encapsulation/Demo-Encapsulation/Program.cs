Console.WriteLine("Main started");
//
Car ford = new Car();
ford.SetSpeed(100);
ford.Speed = 120;
System.Console.WriteLine(ford.GetSpeed());
System.Console.WriteLine(ford.Speed);

//
Console.WriteLine($"Current users count:{User.GetCount()}");
User u1 = new User();
u1.UserName = "Ido";
u1.Password = "1234" ;
//shorter ,managed initialization
User u2 = new User("MOshe","4321");
//
Console.WriteLine($"Current users count:{User.GetCount()}");
Console.WriteLine(u1.GetDetails());
Console.WriteLine(u2.GetDetails());

Console.WriteLine("Main ended");
//
// Math m1 = new Math();
// Console.WriteLine(m1.Addition(1,2));
// //
// Math m2 = new Math();
// Console.WriteLine(m2.Addition(1,2));
// Math.Count++;
// Console.WriteLine(Math.Addition(1,2));
// Console.WriteLine(Math.Multiply(1,2));
