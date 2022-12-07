using System.Diagnostics;
using System.Threading;

namespace MakeFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MakeDinner_SYNC();
            Console.WriteLine("***********");
             MakeDinner_ASYNC();
            //MakeDinner_ParallelForEach();
            //MakeDinner_ParallelFor();
            //MakeDinner_ParallelInvoke();
            //MakeDinner_Thread();
            //MakeDinner_ThreadPool();
            //MakeDinner_Task();
        }
        //
        static async Task MakeDinner_ASYNC()
        {
            Console.WriteLine("MakeDinner_ASYNC:");
            Console.WriteLine("Started making dinner at : " + DateTime.Now.ToLongTimeString());
            Stopwatch sw = Stopwatch.StartNew();
            //
            Task t1 = MakeEggs_ASYNC();
            Task t2 = MakeSalad_ASYNC();
            Task t3 = MakePizza_ASYNC();
            //
            t1.Wait();
            await t2;
            await t3;
            //
            sw.Stop();
            Console.WriteLine($"Ended making dinner at :{DateTime.Now.ToLongTimeString()} , took {sw.ElapsedMilliseconds} ms");

        }
        //
        static void MakeDinner_ParallelForEach()
        {
            Console.WriteLine("MakeDinner_ParallelForEach:");
            Console.WriteLine("Started making dinner at : " + DateTime.Now.ToLongTimeString());
            Stopwatch sw = Stopwatch.StartNew();
            //
            List<Action> actions = new List<Action>() {
                () => MakeEggs(null),
                () => MakeSalad(null),
                () => MakePizza(null)
            };
            Parallel.ForEach<Action>(actions, (action) => action());
            //
            sw.Stop();
            Console.WriteLine($"Ended making dinner at :{DateTime.Now.ToLongTimeString()} , took {sw.ElapsedMilliseconds} ms");

        }
        //
        static void MakeDinner_ParallelFor()
        {
            Console.WriteLine("MakeDinner_ParallelFor:");
            Console.WriteLine("Started making dinner at : " + DateTime.Now.ToLongTimeString());
            Stopwatch sw = Stopwatch.StartNew();
            //
            List<Action> actions = new List<Action>() {
                () => MakeEggs(null),
                () => MakeSalad(null),
                () => MakePizza(null)
            };
            Parallel.For(0, actions.Count, (i) => actions[i]());
            //
            sw.Stop();
            Console.WriteLine($"Ended making dinner at :{DateTime.Now.ToLongTimeString()} , took {sw.ElapsedMilliseconds} ms");

        }
        //
        static void MakeDinner_ParallelInvoke()
        {
            Console.WriteLine("MakeDinner_ParallelInvoke:");
            Console.WriteLine("Started making dinner at : " + DateTime.Now.ToLongTimeString());
            Stopwatch sw = Stopwatch.StartNew();
            //
            Parallel.Invoke(() => MakeEggs(null), () => MakeSalad(null), () => MakePizza(null));
            //
            sw.Stop();
            Console.WriteLine($"Ended making dinner at :{DateTime.Now.ToLongTimeString()} , took {sw.ElapsedMilliseconds} ms");

        }
        //
        static void MakeDinner_ThreadPool()
        {
            Console.WriteLine("MakeDinner_ThreadPool:");
            Console.WriteLine("Started making dinner at : " + DateTime.Now.ToLongTimeString());
            Stopwatch sw = Stopwatch.StartNew();
            //
            ManualResetEvent mre1 = new ManualResetEvent(false);
            ManualResetEvent mre2 = new ManualResetEvent(false);
            ManualResetEvent mre3 = new ManualResetEvent(false);
            //
            ThreadPool.QueueUserWorkItem(MakeEggs, mre1);
            ThreadPool.QueueUserWorkItem(MakePizza, mre2);
            ThreadPool.QueueUserWorkItem(MakeSalad, mre3);
            //
            mre1.WaitOne();
            mre2.WaitOne();
            mre3.WaitOne();
            //
            sw.Stop();
            Console.WriteLine($"Ended making dinner at :{DateTime.Now.ToLongTimeString()} , took {sw.ElapsedMilliseconds} ms");
        }
        //
        static void MakeDinner_Task()
        {
            Console.WriteLine("MakeDinner_Task:");
            Console.WriteLine("Started making dinner at : " + DateTime.Now.ToLongTimeString());
            Stopwatch sw = Stopwatch.StartNew();
            //
            Task t1 = new Task(MakeEggs, null);
            Task t2 = new Task(MakePizza, null);
            Task t3 = new Task(MakeSalad, null);
            //
            t1.Start();
            t2.Start();
            t3.Start();
            //
            t1.Wait();
            t2.Wait();
            t3.Wait();
            //
            sw.Stop();
            Console.WriteLine($"Ended making dinner at :{DateTime.Now.ToLongTimeString()} , took {sw.ElapsedMilliseconds} ms");
        }
        //
        static void MakeDinner_Thread()
        {
            Console.WriteLine("MakeDinner_Thread:");
            Console.WriteLine("Started making dinner at : " + DateTime.Now.ToLongTimeString());
            Stopwatch sw = Stopwatch.StartNew();
            //
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
            sw.Stop();
            Console.WriteLine($"Ended making dinner at :{DateTime.Now.ToLongTimeString()} , took {sw.ElapsedMilliseconds} ms");
        }
        //
        static void MakeDinner_SYNC()
        {
            Console.WriteLine("MakeDinner_SYNC:");
            Console.WriteLine("Started making dinner at : " + DateTime.Now.ToLongTimeString());
            Stopwatch sw = Stopwatch.StartNew();
            //
            MakeEggs();
            MakePizza();
            MakeSalad();
            //
            sw.Stop();
            Console.WriteLine($"Ended making dinner at :{DateTime.Now.ToLongTimeString()} , took {sw.ElapsedMilliseconds} ms");
        }

        static void MakePizza(object o = null)
        {
            Console.WriteLine("Started making pizza at : " + DateTime.Now.ToLongTimeString());
            Thread.Sleep(2000);
            Console.WriteLine("Ended making pizza at : " + DateTime.Now.ToLongTimeString());
            if (o != null)
            {
                (o as ManualResetEvent).Set();
            }
        }

        static void MakeEggs(object o = null)
        {
            Console.WriteLine("Started making eggs at : " + DateTime.Now.ToLongTimeString());
            Thread.Sleep(1000);
            Console.WriteLine("Ended making eggs at : " + DateTime.Now.ToLongTimeString());
            if (o != null)
            {
                (o as ManualResetEvent).Set();
            }
        }

        static void MakeSalad(object o = null)
        {
            Console.WriteLine("Started making salad at : " + DateTime.Now.ToLongTimeString());
            Thread.Sleep(500);
            Console.WriteLine("Ended making salad at : " + DateTime.Now.ToLongTimeString());
            if (o != null)
            {
                (o as ManualResetEvent).Set();
            }
        }

        static async Task MakePizza_ASYNC()
        {
            Console.WriteLine("Started making pizza at : " + DateTime.Now.ToLongTimeString());
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                //do something
                }
                Task.Delay(2000);
            });
            Console.WriteLine("Ended making pizza at : " + DateTime.Now.ToLongTimeString());
        }

        static async Task MakeEggs_ASYNC()
        {
            Console.WriteLine("Started making eggs at : " + DateTime.Now.ToLongTimeString());
            await Task.Delay(1000);
            Console.WriteLine("Ended making eggs at : " + DateTime.Now.ToLongTimeString());
        }

        static async Task MakeSalad_ASYNC()
        {
            Console.WriteLine("Started making salad at : " + DateTime.Now.ToLongTimeString());
            await Task.Delay(500);
            Console.WriteLine("Ended making salad at : " + DateTime.Now.ToLongTimeString());
        }

    }
}