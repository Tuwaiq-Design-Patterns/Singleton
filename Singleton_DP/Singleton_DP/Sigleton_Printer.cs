using System;

namespace Singleton_DP
{
    class Printer
    {
        private static Printer _instance = null;
        private Printer()
        {
            Console.WriteLine("Singleton Initilized");
        }
        public static Printer getInstance()
        {
            if(_instance == null)
            {
                _instance = new Printer();
            }

            return _instance;
        }

        public void print_papers()
        {
            Console.WriteLine("Print Papers");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Printer singleton = Printer.getInstance();
            Printer singleton2 = Printer.getInstance();

            //Printer singleton2
        }
    }
}
