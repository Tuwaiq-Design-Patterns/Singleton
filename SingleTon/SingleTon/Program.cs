using SingleTon;
using System;
using System.Threading;

namespace SingleTon
{

    public class Singleton
    {

        private static Singleton instance;
        private static readonly object padlock = new object();


        private Singleton()
        { }

        public static Singleton GetInstance()
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new Singleton();
                    Console.WriteLine("Enter GetInstance");
                }
                return instance;
            }
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
           // Singleton s1 = Singleton.GetInstance();
           // Singleton s2 = Singleton.GetInstance();

            Singleton s1 = null;
            Singleton s2 = null;

            Thread th1 = new Thread(() =>
            {
                Singleton s1 = Singleton.GetInstance();
            });

            Thread th2 = new Thread(() =>
            {
                Singleton s2 = Singleton.GetInstance();
            });

            th1.Start();
            th2.Start();

            if (s1 == s2)
            {
                Console.WriteLine("same");
            }
            else
            {
                Console.WriteLine("Not same");
            }


        }
    }
}

