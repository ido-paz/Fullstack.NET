class Program
{
    static void Main()
    {
        ParentExecute();
        DerivedExecute();
        ParentDerivedExceute();
    }
    //
    static void ParentExecute()
    {
        System.Console.WriteLine("Executing parent class methods");
        Parent p1 = new Parent();
        Parent p2 = new Derived1();
        Parent p3 = new Derived2();
        p1.M1();//Parent M1
        p1.M2();//Parent M2
        //
        p2.M1();//Parent M1
        p2.M2();//Derived1 M2
        //
        p3.M1();//Parent M1
        p3.M2();//Parent M2
    }
    //
    static void DerivedExecute()
    {
        //Derived1 d0 = new Parent();//excprtion , need conversion
        System.Console.WriteLine("Executing methods on derived class");
        Derived1 d1 = new Derived1();
        Derived2 d2 = new Derived2();
        d1.M1();//Parent M1
        d1.M2();//Derived1 M2
        d2.M1();//Derived2 M1
        d2.M2();//Derived2 M2
    }

    static void ParentDerivedExceute()
    {
        Parent p1 = new Parent();
        Parent p2 = new Derived1();
        Parent p3 = new Derived2();
        Derived1 d1 = new Derived1();
        Derived2 d2 = new Derived2();
        Parent[] ps = new Parent[] { p1, p2, p3, d1, d2 };
        System.Console.WriteLine("Executing parent ,derived classes methods on items in an array");
        foreach (var p in ps)
        {
            p.M2();
        }
    }
}

