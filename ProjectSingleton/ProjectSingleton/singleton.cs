using System;
namespace ProjectSingleton
{
    public class Singleton
    {
        static Singleton object_Singleton;
        public string Value { get; set; }
        private Singleton()
        {

        }


        public static Singleton GetSingleton()
        {

            if (object_Singleton ==null)
            {
                Console.WriteLine("Create New Singleton object");
                object_Singleton = new Singleton();
            }
                return object_Singleton;
        }
    }
}
