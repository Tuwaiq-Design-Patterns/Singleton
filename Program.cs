using System;
using System.Runtime.CompilerServices;

namespace Singleton
{

    class Singleton
    {
        private static Singleton _singleton;

        public Singleton()
        {
        }

         public static Singleton getInstance()
         {
             return _singleton ?? new Singleton();
         }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s = Singleton.getInstance();
            Singleton s2 = Singleton.getInstance();
            Console.WriteLine(s.Equals(s2));
            Console.WriteLine(s.GetHashCode());
            Console.WriteLine(s2.GetHashCode());
        }
    }
}