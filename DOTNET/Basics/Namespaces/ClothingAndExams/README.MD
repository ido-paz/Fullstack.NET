# Namespaces practice

1. Create Clothing name space that contains Size enum , Pants class.
2. Create Teaching name space that contains Grade enum , Exam class.
3. Use the created namespaces ,classes , enums to make the following code work:

<pre>
using Clothing;
using System;
//
class Program
{
    static void Main()
    {
        Teaching.Exam e1 = new Teaching.Exam()
        {
            Grade = Teaching.Grade.Passed,
            Name = "Math"
        };
        Clothing.Pants p1 = new Clothing.Pants()
        {
            Brand = "Levis",
            Size = Clothing.Size.Medium
        };
        Pants p2 = new Pants()
        {
            Brand = "Diesel",
            Size = Clothing.Size.Large
        };
        System.Console.WriteLine(e1);
        System.Console.WriteLine(p1);
        System.Console.WriteLine(p2);
        //
    }
}
</pre>
