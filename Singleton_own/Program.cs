using System;
using System.Threading;
namespace Singleton
{
    // not thread-safe singleton
    class SingleDefault
    {
        public string localStr;
        private static SingleDefault single;
        private SingleDefault(string str) => this.localStr = str;
        public static SingleDefault getInstant(string str)
        => single ??= new(str);
    }
    class SingleThreadSafe
    {
        public string localStr;
        private static Mutex _lock = new();
        private static SingleThreadSafe single;
        private SingleThreadSafe(string str) => this.localStr = str;
        public static SingleThreadSafe getInstant(string str)
        {
            _lock.WaitOne();
            single ??= new(str);
            _lock.ReleaseMutex();
            return single;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // The client code.            
            Console.WriteLine(
                "{0}\n{1}\n\n{2}\n",
                "If you see the same value, then singleton was reused (yay!)",
                "If you see different values, then 2 singletons were created (booo!!)",
                "RESULT:"
            );
            Thread process1 = new Thread(() =>
            {
                TestSingleton("FOO");
            });
            Thread process2 = new Thread(() =>
            {
                TestSingleton("BAR");
            });
            process1.Start();
            process2.Start();
            process1.Join();
            process2.Join();
        }
        public static void TestSingleton(string value)
        {
            SingleDefault singleton = SingleDefault.getInstant(value);
            Console.WriteLine(singleton.localStr);
        }
    }
}