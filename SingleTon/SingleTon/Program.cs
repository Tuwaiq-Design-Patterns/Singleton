using System;
using System.Threading;


namespace SingleTon

{

    class Singletonpattern
    {
        private static Singletonpattern stp = new Singletonpattern();

            private  Singletonpattern()
            {
            
            }

        public static Singletonpattern getIntance()
        {
            return stp;
        }
    }
    public class Shop
    {
        private static Shop instance = new Shop(243);

        public int NumberProducts { get; set; }
        public int NumberClients { get; set; }

        public static Shop GetInstance()
        {
            return instance;
        }

        private Shop(int numberproducts)
        {
            NumberProducts = numberproducts;
        }

        public void NewClient()
        {
            NumberClients += 1;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
           
            Singletonpattern instance3 = Singletonpattern.getIntance();
            Console.WriteLine(instance3);
            Shop instance = Shop.GetInstance();

            Console.WriteLine(instance.NumberProducts);
            Shop instance2 = Shop.GetInstance();

            instance2.NewClient();

            Console.WriteLine(instance.NumberClients);
            Console.WriteLine(instance2.NumberClients);

            Console.ReadKey();
        }
    }
}
