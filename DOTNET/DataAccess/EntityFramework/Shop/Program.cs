
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Shop_Console started");
        //
        Display_Products_CRUD_UI();
        //
        Console.WriteLine("Shop_Console ended");
    }

    private static void Display_Products_CRUD_UI()
    {
        //ProductsDB pdb = new ProductsDB();
        //string selection = null, name, newTitle, price;
        //const string MENU = @"Enter your selection:
        //        s = show all products
        //        c = create product
        //        u = update product
        //        d = delete product
        //        q = quit app";
        //while (selection != "q")
        //{
        //    Console.Clear();
        //    Console.WriteLine(MENU);
        //    selection = Console.ReadLine().Trim().ToLower();
        //    if (selection == "s")
        //    {
        //        Console.WriteLine("Showing all products");
        //        foreach (var product in pdb.GetAll())
        //            Console.WriteLine(product);
        //    }
        //    else if (selection == "c")
        //    {
        //        Console.WriteLine("Enter name and press enter");
        //        name = Console.ReadLine().Trim();
        //        Console.WriteLine("Enter price and press enter");
        //        price = Console.ReadLine().Trim().ToLower();
        //        //
        //        pdb.Insert(new Product() { Name = name, Price = decimal.Parse(price) });

        //    }
        //    else if (selection == "u")
        //    {
        //        Console.WriteLine("Enter old name and press enter");
        //        name = Console.ReadLine().Trim();
        //        Console.WriteLine("Enter new name and press enter");
        //        newTitle = Console.ReadLine().Trim();
        //        Console.WriteLine("Enter new price and press enter");
        //        price = Console.ReadLine().Trim().ToLower();
        //        //
        //        Product product = pdb.Get(name);
        //        if (product != null)
        //        {
        //            product.Name = newTitle;
        //            product.Price = decimal.Parse(price);
        //            pdb.Update(product);
        //        }
        //        else
        //            Console.WriteLine($"Product with name '{name}' was not found");
        //    }
        //    else if (selection == "d")
        //    {
        //        Console.WriteLine("Enter name and press enter");
        //        name = Console.ReadLine().Trim();
        //        //
        //        Product product = pdb.Get(name);
        //        if (product != null)
        //        {
        //            pdb.Delete(product);
        //        }
        //        else
        //            Console.WriteLine($"Product with name '{name}' was not found");

        //    }
        //    else if (selection != "q")
        //    {
        //        Console.WriteLine("Invalid selection");
        //    }
        //    Console.WriteLine("Press any key to show the selection menu");
        //    Console.ReadLine();
        //}
    }
}