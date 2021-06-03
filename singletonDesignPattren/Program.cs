using System;

namespace singletonDesignPattren
{

    class Singleton
    {

        private static Singleton instance;
       
        private Singleton() { }


        public static Singleton getInstance()
        {
            if (instance == null)
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

            Singleton s1 = Singleton.getInstance();
            Singleton s2 = Singleton.getInstance();

   

            if (s1 == s2)
            {
                Console.WriteLine("objects are the same instance");


            }else
            {
                Console.WriteLine("objects are not the same instance");
            }


        }
    }
}
