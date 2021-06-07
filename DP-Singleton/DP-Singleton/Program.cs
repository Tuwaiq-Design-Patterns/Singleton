using System;
using System.Threading;

namespace DP_Singleton
{
    sealed class Singleton // sealed doesn't allow other classes to inherit from it
    {
        private static Singleton instance = null; // static to make sure it doesn't create another instance to another object
        private static readonly object _lock = new object();

        private Singleton() // Constructor has to be private so no one can change or edit it
        {

        }
        public static Singleton getInstance() // Has to be public to use it outside of class
        {
            if(instance == null) // If instance doesn't exist,
            {

                lock(_lock)
                {
                    if (instance == null) 
                    {
                        //Console.WriteLine("Enter getInstance");
                        instance = new Singleton(); // Create new instance
                    }
                }
                
            }
            return instance;
        }
    }
    class Program
    { 
        static void Main(string[] args)
        {
        Singleton S1 = null; // = Singleton.getInstance();
        Singleton S2 = null; // = Singleton.getInstance();

        //Singleton S3 = Singleton.getInstance();
        
        Thread th1 = new Thread(() => 
        {
            S1 = Singleton.getInstance(); 
        });
        Thread th2 = new Thread(() =>
        {
            S2 = Singleton.getInstance();
        });
            th1.Start();
            th2.Start();

            /*
                Singleton S1 = Singleton.getInstance();
                Singleton S2 = Singleton.getInstance();
            */
            if (S1 == S2)
            {
                Console.WriteLine("Singleton works");
            }
            else
            {
                Console.WriteLine("Singleton doesn't work");
            }


        Console.ReadKey();
        }
    }
}
