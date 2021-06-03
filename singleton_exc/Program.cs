using System;

namespace singleton_exc
{
    public class SingleTon
    {
        private static SingleTon obj;
        private SingleTon() { }
        public static SingleTon getInstance() {
            if (obj == null)
            {
                obj = new SingleTon();
            }
            return obj;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SingleTon s1= SingleTon.getInstance();
            SingleTon s2 = SingleTon.getInstance();

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            if (s1 == s2)
            {
                Console.WriteLine(" objaects are same .");
            }
            else
            {
                Console.WriteLine(" objaects are (NOT) same .");

            }
        }
    }
}
