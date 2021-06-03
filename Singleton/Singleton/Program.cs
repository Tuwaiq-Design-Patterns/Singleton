using System;
using System.Threading;
namespace Singleton
{  
        class Program
        {

            static void Main(string[] args)
            {
                singleton instance1 = null;
                singleton instance2 = null;


                //thread save singleton
                Thread th1 = new Thread(() =>
                {

                    instance1 = singleton.getInstance();
                });


                Thread th2 = new Thread(() =>
                {

                    instance2 = singleton.getInstance();
                });


                if (instance1 == instance2)
                    Console.WriteLine("Same objects");
                else
                    Console.WriteLine("Different objects");


            }
        }
    }

public class singleton
{
    private static singleton instance;
    private singleton() { }
    public static singleton getInstance()
    {
        if (instance == null)
        {
            instance = new singleton();
        }
        return instance;
    }
}