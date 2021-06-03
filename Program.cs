using System;

namespace Singleton
{
    public class Storage
    {
        private static int count;
        private static Storage Instance;

        private Storage()
        {
            count++;
        }

        public void Print()
        {
            Console.WriteLine("Storage instance count: " + count);
        }
        
        public static Storage getInstance()
        {
            if (Instance != null)
                return Instance;
            
            lock (Instance)
            {
                if (Instance == null)
                {
                    Instance = new Storage();
                }
                return Instance;
            }
        }
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            Storage storage1 = Storage.getInstance();
            Storage storage2 = Storage.getInstance();
            
            storage1.Print();
            storage2.Print();
        }
    }
}