using System;
using System.Threading;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = null;
            Singleton s2 = null;
            
            Thread th1 = new Thread(() => {
                s1 = Singleton.GetInstance();
            });
            Thread th2 = new Thread(() => {
                s2 = Singleton.GetInstance();
            });
            
            th1.Start();
            th2.Start();
            th1.Join();
            th2.Join();
            
            if (s1 == s2)
            {
                Console.WriteLine("Singleton was applied successfully..the prove is down...");
                Console.WriteLine(s1.GetHashCode().ToString());
                Console.WriteLine(s2.GetHashCode().ToString());
            }
            else
            {
                Console.WriteLine("WAT !!!!");
            }
        }
    }

    class Singleton
    {
        private static Singleton _instance;
        private static readonly object _lock = new object();

        private Singleton()
        {
            
        }

        public static Singleton GetInstance()
        {
            // if (instence == null)
            // {
            //     Console.WriteLine("new instence");
            //     instence = new Singleton();
            //     return instence;
            // }
            // Console.WriteLine("instence already created");
            // return instence;
            
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new Singleton();
                }
            }
            return _instance;
        }
    }
}