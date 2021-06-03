using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 == s2) Console.WriteLine("objaects are the same.");
            else Console.WriteLine("objaects NOT the same .");
        }
    }
    class Singleton
    {
        private Singleton() { }
        private static Singleton _instance;
        public static Singleton GetInstance() => _instance ??= new Singleton();

    }
}