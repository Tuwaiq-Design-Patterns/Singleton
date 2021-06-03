using System;
using System.Threading;

namespace SingletonPractice
{

    class Singleton
    {

        private static Singleton _instance;

        private Singleton()
        {

        }


        public static Singleton getInstance()
        {
            if(_instance == null)
            {
                _instance = new Singleton();
                return _instance;
            }
            else
            {
                return _instance;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Singleton test1 = Singleton.getInstance();
            Singleton test2 = Singleton.getInstance();
            

            if (test1 == test2)
            {
                Console.WriteLine("THEY ARE THE SAME.");
            }
            else
            {
                Console.WriteLine("THEY ARE **NOT** THE SAME.");
            }

        }
    }
}
