using System;

namespace Singleton
{
    class Program
    {
        public class Singleton
        {
            private static Singleton instance;

            private Singleton()
            {
              
            }

            public static Singleton getInstance()
            {
                if (instance != null)
                {
                    Console.WriteLine("Returning Instance");
                    return instance;
                } 
                else
                {
                    Console.WriteLine("Creating new instance");
                    instance = new Singleton();
                    return instance;
                }
            }

        }
        static void Main(string[] args)
        {

            Singleton singleton = Singleton.getInstance();
            Singleton singleton2 = Singleton.getInstance();
        }
    }
}
