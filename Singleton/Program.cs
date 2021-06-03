using System;

namespace Singleton
{
    public sealed class Singleton
    {
        private Singleton() { }
        private static Singleton instance = null;
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var singleton = Singleton.Instance;

            //Console.WriteLine("Hello World!");
        }
    }
}
