using System;
using System.Threading;
namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = null;
            Singleton s2 = null;

            s1 = Singleton.getInstance();
            s2 = Singleton.getInstance();

            Thread th1 = new Thread(() =>
            {
                s1 = Singleton.getInstance();
            });

            Thread th2 = new Thread(() =>
            {
                s2 = Singleton.getInstance();
            });

            th1.Start();
            th2.Start();

            Console.WriteLine(s1 == s2);

        }
    }

    class Singleton
    {
        private static Singleton instance;
        private Singleton()
        {

        }

        public static Singleton getInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
                Console.WriteLine("get instance");
            }
            return instance;        
        }
    }
}
