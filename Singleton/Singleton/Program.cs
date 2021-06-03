using System;
using System.Threading;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton k = null;
            Singleton j = null;
            Thread th1 = new Thread(() =>
            {
                k = Singleton.getInctence();
            });
            Thread th2 = new Thread(() =>
            {
                j = Singleton.getInctence();
            });
            th1.Start();
            th2.Start();
            Console.WriteLine(k == j);
        }
    }
}