using System;
using System.Threading;

namespace Singleton
{

    sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object locked = new Object(); //here we lock object if there is another object work 
        private Singleton()
        {
        }
        public static Singleton GetSingleton
        {
            get{
               
                {
                    if (instance == null) //check if there is another instance of singleton or not . 
                    {
                        lock (locked)
                        instance = new Singleton();
                        Console.WriteLine("instance created..");
                    }
                    return instance;
                }
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = null;
            Singleton s2 = null;
          


            Thread t1 = new Thread(() =>
            {
                 s1 = Singleton.GetSingleton;
                 
            });
            Thread t2 = new Thread(() =>
            {
                 s2 = Singleton.GetSingleton;
            });
            /*Singleton s1 = Singleton.GetSingleton();
            Singleton s2 = Singleton.GetSingleton();
            
            */
            t1.Start();
            t2.Start();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton Work ..");
            }
            else
            {
                Console.WriteLine("Singleton doesn't work..");
            }



        }
    }
}
