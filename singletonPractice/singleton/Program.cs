using System;

namespace singleton
{
    class Singleton
    {
        private Singleton()
        {

        }

        private static Singleton instance;

        public static Singleton GetInstance()
        {
            if (instance ==null)
            {
                instance = new Singleton();
            }

            return instance;
            
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {

            Singleton s = Singleton.GetInstance();

            Console.WriteLine("Singleton " + s);

            Singleton s2 = Singleton.GetInstance();
            Console.WriteLine("Singleton " + s2);

            if (s == s2)
            {
                Console.WriteLine("instances are the same");

            }
            else
            {
                Console.WriteLine("they are differenct");
            }
        }
    }
}
