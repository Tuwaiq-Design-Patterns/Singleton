using System;
using static System.Console;

namespace Singleton
{
    class Program
    {
        static void Main()
        {
            Singleton s = Singleton.Create();
            Singleton d = Singleton.Create();
            WriteLine(d == s);
        }
    }
    public class Singleton
    {
        private static Singleton _singleton;
        private Singleton() { }
        public static Singleton Create() => _singleton ??= new Singleton();
    }
}