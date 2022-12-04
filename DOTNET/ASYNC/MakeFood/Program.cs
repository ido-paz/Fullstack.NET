using System.Threading;

namespace MakeFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MakeDinner_SYNC();
            //Console.WriteLine("***********");
            MakeDinner_Thread();
        }

        static void MakeDinner_Thread()
        {
            Console.WriteLine("MakeDinner_Thread:");
            Console.WriteLine("Started making dinner at : " + DateTime.Now.ToLongTimeString());
            Thread t1 = new Thread(MakeEggs);
            Thread t2 = new Thread(MakePizza);
            Thread t3 = new Thread(MakeSalad);
            //
            t1.Start();
            t2.Start();
            t3.Start();
            //
            t1.Join();
            t2.Join();
            t3.Join();
            //
            Console.WriteLine("Ended making dinner at : " + DateTime.Now.ToLongTimeString());
        }

        static void MakeDinner_SYNC()
        {
            Console.WriteLine("MakeDinner_SYNC:");
            Console.WriteLine("Started making dinner at : " + DateTime.Now.ToLongTimeString());
            MakeEggs();
            MakePizza();
            MakeSalad();
            Console.WriteLine("Ended making dinner at : " + DateTime.Now.ToLongTimeString());
        }

        static void MakePizza()
        {
            Console.WriteLine("Started making pizza at : " + DateTime.Now.ToLongTimeString());
            Thread.Sleep(2000);
            Console.WriteLine("Ended making pizza at : " + DateTime.Now.ToLongTimeString());
        }

        static void MakeEggs()
        {
            Console.WriteLine("Started making eggs at : " + DateTime.Now.ToLongTimeString());
            Thread.Sleep(1000);
            Console.WriteLine("Ended making eggs at : " + DateTime.Now.ToLongTimeString());
        }

        static void MakeSalad()
        {
            Console.WriteLine("Started making salad at : " + DateTime.Now.ToLongTimeString());
            Thread.Sleep(500);
            Console.WriteLine("Ended making salad at : " + DateTime.Now.ToLongTimeString());
        }
    }
}