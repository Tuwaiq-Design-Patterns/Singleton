using System;

namespace singletonExample
{
    class Singleton
    {
        private static Singleton instance;
        private Singleton() { }
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null) instance = new Singleton();
                return instance;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Singleton newInstance = Singleton.GetInstance;
        }
    }
}
