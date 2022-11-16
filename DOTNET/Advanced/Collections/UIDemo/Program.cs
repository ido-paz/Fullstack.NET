using System;

namespace UIDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //create
            
            //add item

            //remove item 

            //is item exits?

            //enumarate

            //clear all items
            Console.WriteLine("Using collection X example");
            var collection = new object();
            bool showMenu = true;
            //
            while (showMenu)
            {
                showMenu = ShowMenu(collection);
                Console.WriteLine("press any key to continue...");
                Console.ReadLine();
            }
        }

        static bool ShowMenu(object collection)
        {
            string userStringInput;
            // Ask the user to choose an option.
            Console.Clear();
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\td - Remove");
            Console.WriteLine("\te - Enumerate");
            Console.WriteLine("\tb - Contains");
            Console.WriteLine("\tc - Clear");
            Console.WriteLine("\tq - Quit");
            Console.Write("Your option? ");
            //
            userStringInput = GetUserSelectedLoweredChar();
            Console.WriteLine();
            switch (userStringInput)
            {
                case "a":// Adding an item into collection
                    Console.WriteLine("Enter a value to added to the collection:");
                    return true;
                case "d":// Removing the first item from collection
                    Console.WriteLine("Enter a value to remove from collection:");
                    return true;
                case "e":// Enumerating a collection
                    Console.WriteLine("collection contains the following items:");
                    return true;
                case "b":// Checking a collection
                    Console.WriteLine("Enter a value to find in the collection:");
                    return true;
                case "c":// Clearing the collection
                    Console.WriteLine("Clearing the collection...");
                    return true;
                case "q":// Wait for the user to respond before closing.
                    Console.Write("Quiting the console application...");
                    return false;
                default:
                    Console.Write("Invalid key");
                    return true;
            }
        }
        //
        static string GetUserSelectedLoweredChar()
        {
            return Console.ReadKey().KeyChar.ToString().ToLower();
        }
        //
    }
}
