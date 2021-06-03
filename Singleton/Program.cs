using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton one = Singleton.GetInstance();
            Singleton two = Singleton.GetInstance();

        }
    }

    public class Singleton
    {
        private static Singleton Instance;
        private Singleton() 
        {
            Console.WriteLine("Instance Created");
        }
        public static Singleton GetInstance()
        {
            if(Instance == null)
            {
                Instance = new Singleton();
            }

            return Instance;
        }
    }
}
