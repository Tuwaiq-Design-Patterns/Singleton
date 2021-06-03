using System;

namespace Singlton_first_Example
{
    public class singlton
    {
        private static singlton ins;
        private string f;
        private singlton() { }
        public static singlton getIns() 
        {
            if (ins == null)
            {
                ins = new singlton();
                ins.f = "this is printable";

            }

            return ins;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            singlton r= singlton.getIns();
            singlton x = singlton.getIns();

            if (r==x)
            {
                Console.WriteLine("true");

            }
        }
    }
    
}
