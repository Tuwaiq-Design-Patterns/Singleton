using System;
using System.Threading;

namespace Singleton
{
    class Program
    {
        class Singleton
        {
            private static Singleton obj;
            private static readonly object padlock = new object();

            private Singleton()
            {

            }

            public static Singleton getInstauce()
            {
                lock (padlock)
                {

                    if (obj == null)
                    {
                        Console.WriteLine("Enter GetInstance");
                        return obj = new Singleton();
                        
                    }
                    return obj;
                }
            }

        }
        static void Main(string[] args)
        {
            Singleton s1 = null;
            Singleton s2 = null;

            Thread th1 = new Thread(() =>
            {
                s1 = Singleton.getInstauce();
            });

            Thread th2 = new Thread(() =>
            {
                s2 = Singleton.getInstauce();
            });

            th1.Start();
            th2.Start();

            if (s1 == s2)
            {
                Console.WriteLine("object are same instance");
            }
            else
            {
                Console.WriteLine("object are not same instance");
            }
        }
    }
}
