using System;
using System.Threading;

namespace SPPLab3
{
    class Program
    {
        static Mutex mutex = new Mutex();

        public static void Main()
        {
            Thread fThread = new Thread(Paint);
            Thread sThread = new Thread(Paint);

            fThread.Start();
            sThread.Start();

        }

        static void Paint()
        { 
            mutex.Lock();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("#");
                    Thread.Sleep(20);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            mutex.Unlock();
        }
    }
}
