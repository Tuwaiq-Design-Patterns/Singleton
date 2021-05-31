using System;
using System.Threading;

namespace singleton_
{
    class Singleton
    {
        private static Singleton instance;
        private static readonly object _lock = new object();

        private Singleton()
        {
        }

        public static Singleton getInstance()
        {
            if (instance == null)
            {
                lock (_lock)
                {
                    if (instance == null)
                        instance = new Singleton();
                }
            }

            return instance;
        }

    }

    class Program
    {


        static void Main(string[] args)
        {
            Singleton s1 = null;
            Singleton s2 = null;


            //thread save singleton
            Thread th1 = new Thread(() => {

                s1 = Singleton.getInstance();
            });


            Thread th2 = new Thread(() => {

                s2 = Singleton.getInstance();
            });

            //Check if the object is created again or it's same
            if (s1 == s2)
                Console.WriteLine("Same");
            else
                Console.WriteLine("Not");


        }

    }
}
