using System;
using System.Threading;

namespace tpThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread myThread; 

            myThread = new Thread(new ThreadStart(ThreadLoop));
            myThread.Start();
            Console.WriteLine("Je suis une thread.");
        }

        public static void ThreadLoop()
        {
            while(Thread.CurrentThread.IsAlive)
            {
                Thread.Sleep(500);
                Console.WriteLine("Je travaille ..");
                
            }
        }
    }
}
