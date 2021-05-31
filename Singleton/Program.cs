using System;
using System.Threading;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Singleton");
            Singleton myInstance= Singleton.Instance;
            Console.WriteLine("first instance hashcode: "+myInstance.GetHashCode());
            Singleton myInstance2 = Singleton.Instance;
            Console.WriteLine("second instance hashcode: " + myInstance2.GetHashCode());
            // hashCode method to provide a numeric representation of an object's contents so at start it's always the same for singleton instances

            Console.WriteLine("No Singleton");
            NoSingleton myInstanceN = NoSingleton.Instance;
            Console.WriteLine("first instance hashcode: " + myInstanceN.GetHashCode());
            NoSingleton myInstanceN2 = NoSingleton.Instance;
            Console.WriteLine("second instance hashcode: " + myInstanceN2.GetHashCode());

            Console.WriteLine("Singleton in Threads");
            Singleton in1 = Singleton.Instance; ;
            Singleton in2 = Singleton.Instance; ;
            Singleton in3 = Singleton.Instance;
            Thread thread1 = new Thread(() =>
            {
                in1 = Singleton.Instance;
            });
            Thread thread2 = new Thread(() =>
            {
                in2 = Singleton.Instance;
            });

            thread1.Start();
            thread2.Start();
            Thread.Sleep(3000);
            Console.WriteLine("first instance hashcode: " + in1.GetHashCode());
            Console.WriteLine("second instance hashcode: " + in2.GetHashCode());


        }
    }


    // Only initiate a one instance of the class 
    public class Singleton
    {
        private static Singleton instance;

        //constructor is private to prevent initiating an instance of the class
        private Singleton()
        {

        }
        public static Singleton Instance { 
            get 
            {
                if (instance == null) instance = new Singleton();
                return instance;
            } 
        }
    }


    // always initiate a new instance of the class 
    public class NoSingleton
    {
        private static NoSingleton instance;

        private NoSingleton()
        {

        }
        public static NoSingleton Instance
        {
            get
            {
                instance = new NoSingleton();
                return instance;
            }
        }
    }
}



