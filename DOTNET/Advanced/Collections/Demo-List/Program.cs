using System.Collections.Generic;
using System.Collections;
class Program
{
    static void Main()
    {
        
    }

    static void ArrayList(){
        ArrayList names = new ArrayList();
        names.Add("Ido");
        names.Add(1);
        names.Add(false);
        names.Add(new System.DateTime());
        //
        bool removed = names.Remove("Moshe");
        //
        names[1] = "Alina";
        //        
        System.Console.WriteLine(((System.DateTime)names[3]).ToLongTimeString());
    }
    static void IntList()
    {
        List<int> ages = new List<int>();
        ages.Add(21);
        ages.Add(11);
        ages.Add(74);
        //
        bool removed = ages.Remove(12);
        //
        ages[1] = 55;
        System.Console.WriteLine(ages[0]);
    }

    static void StringList()
    {
        List<string> names = new List<string>();
        names.Add("Ido");
        names.Add("Moshe");
        names.Add("David");
        //
        bool removed = names.Remove("Moshe");
        //
        names[1] = "Alina";
        //
        System.Console.WriteLine(names[0]);
    }
}