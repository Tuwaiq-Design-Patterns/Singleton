using System;

namespace SingletonApp
{
    class Program
    {
        public int number;

        static void Main(string[] args)
        {
            Printer p1 = Printer.GetInstance();
            Printer p2 = Printer.GetInstance();


            if (p1 == p2)
            {
                Console.WriteLine("Same Instance");
            }

            var p = new Program();
            p.test();
            p.test();


            Console.ReadKey();
        }

        public void test()
        {
            // thread 1
            int num1 = getNumber();
            setNumber(num1 + 2);

            // thread 2
            int num2 = getNumber();
            setNumber(num2 + 2);
        }

        public void setNumber(int input)
        {
            lock(this)
            {
                number = input;
            }
        }

        public int getNumber()
        {
            lock(this)
            {
                return number;
            }
        }
    }


    class Printer

    {
        private static Printer _instance;


        private Printer()
        {
            
        }

        public static Printer GetInstance()
        {

            lock(_instance)
            {
                if (_instance == null)
                {
                    _instance = new Printer();
                }
            }

            return _instance;
        }

    }
}
