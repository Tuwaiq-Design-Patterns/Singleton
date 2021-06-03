using System;
using System.Threading;
using System.Collections.Generic;


namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var threads = new List<Thread>();
            for (int i = 0; i < 20; i++) threads.Add(new Thread(new ThreadStart(WorkOnSingleton)));
            foreach (var thread in threads) thread.Start();
        }

        public static void WorkOnSingleton()
        {
            while (true)
                Console.WriteLine($"{Singleton.GetInstance().FlipZeroOneField()}");
        }
    }
}
