using System;
using System.Threading;
namespace DesignPattern_singletone
{
    class Singleton{
        public static int count = 0;
        private Singleton()
        {
            Console.WriteLine("The number of instance:  "+ ++count);
        }
        private static Singleton _inctance;
        private static readonly object _lock = new object();


        public static Singleton getSingleton()
        {
            if (_inctance == null)
            {
                _inctance = new Singleton();
            }
            return _inctance;
        }

        public static Singleton getSingletonWithLocking()
        {
            /* This method is an implementation of attempted thread-safety, using double-check locking */
            if (_inctance == null)
            {
                lock (_lock)
                {
                    if (_inctance == null)
                    {
                        _inctance = new Singleton();
                    }
                        
                }
            }
            return _inctance;
        }
         public int Count()
        {
            return count;
        }
    }



    // client 
    class Program
    {

        static void Main(string[] args)
        {
            // Note: when you are testing one part of the three below, kindly comments out the other parts (:


            /*********************************************************************************************
                (1) Basic case of using Singleton
                result: one instance.
             *********************************************************************************************/

            Singleton firstS = Singleton.getSingleton();
            Singleton secondS = Singleton.getSingleton();

            if (firstS.Count() == secondS.Count())
                Console.WriteLine("We are trying to get the same instance at the same time, " +
                    "and this is invalid step based on the Singleton principe");
            else
                Console.WriteLine("We have no interest to get the same instance at the meantime. Actually one of us got it first!!");





            /*********************************************************************************************
                (2) In case of having two nulls and both trying to get an instance, by using threading.
                result: 2 instances <--- which is the problem (worst case) we got when we use Singleton.
            *********************************************************************************************/

            //Singleton firstTS = null;
            //Singleton secondTS = null;

            //Thread thread1 = new Thread(() =>
            //{
            //    firstTS = Singleton.getSingleton();

            //});

            //Thread thread2 = new Thread(() =>
            //{
            //    secondTS = Singleton.getSingleton();
            //});
            //thread1.Start();
            //thread2.Start();

            //thread1.Join();
            //thread2.Join();




            /********************************************************************************************
                (3) Now, we have the same case as #2 where we have two nulls and both trying to get an instance,
                    but this time we use the implementation of attempted thread-safety( using double-check locking) :
                result: 1 instance <--- the solution to the problem we got in case (2).
            *********************************************************************************************/

            //Singleton firstTS = null;
            //Singleton secondTS = null;

            //Thread thread1 = new Thread(() =>
            //{
            //    firstTS = Singleton.getSingletonWithLocking();
            //});

            //Thread thread2 = new Thread(() =>
            //{
            //    secondTS = Singleton.getSingletonWithLocking();
            //});
            //thread1.Start();
            //thread2.Start();

            //thread1.Join();
            //thread2.Join();

            //if (firstTS.Count() == secondTS.Count())
            //    Console.WriteLine("We are trying to get the same instance at the same time, " +
            //        "and this is invalid step based on the Singleton principe");
            //else
            //    Console.WriteLine("We have no interest to get the same instance at the meantime. Actually one of us got it first!!");


        }
    }
}

