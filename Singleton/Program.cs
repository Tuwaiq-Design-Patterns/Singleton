using System;

namespace Singleton
{
    
    class Singleton
    {
       
        private Singleton() { }

        private static Singleton instance;

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        public static void someBusinessLogic()
        {
            Console.WriteLine("Magic");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            Singleton sing1 = Singleton.GetInstance();
            Singleton sing2 = Singleton.GetInstance();

            if (sing1 == sing2)
            {
                Console.WriteLine("Singleton works!");
            }
            else
            {
                Console.WriteLine("Singleton doesn't work..");
            }
        }
    }
}
