using System;
using System.Threading;
namespace singleton_design_pattern
{
    sealed class Singleton
    {

        private static Singleton instance;
        private Singleton()
        {

        }
        public static Singleton getInstance()
        {
            if(instance == null)
            {
                Console.WriteLine("creating instance....");
                instance = new Singleton();
            }
            return instance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s = null;
            Singleton s2 = null;
            Thread th1 = new Thread(()=>
            {
                s = Singleton.getInstance();

            });
            Thread th2 = new Thread(() =>
            {
                s2 = Singleton.getInstance();

            });
            th1.Start();
            th2.Start();
            //Singleton s = Singleton.getInstance();
            //Console.WriteLine(s);
            //Singleton s2 = Singleton.getInstance();
            Console.WriteLine(s2 == s);
        }
    }
}
