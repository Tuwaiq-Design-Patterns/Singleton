using System;
namespace Singleton
{

       public class singleton
    {
        private static singleton instance;
        private singleton() { }
        public static singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new singleton();
            }
            return instance;
        }
    
  

    class Program
    {
        static void Main(string[] args)
        { 
        
            singleton instance1 = singleton.GetInstance();
            singleton instance2 = singleton.GetInstance();

            Console.WriteLine(instance1);
            Console.WriteLine(instance2);

            if (instance1 == instance2)
            {
                Console.WriteLine(" same instance");
            }
            else
            {
                Console.WriteLine(" NOT same instance");

            }

        }
    }

}