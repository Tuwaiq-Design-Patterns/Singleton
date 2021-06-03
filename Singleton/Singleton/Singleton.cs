using System;
using System.Threading;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton instance;
        private static readonly object _lock = new object();

        private Singleton(){}

        public static Singleton getInctence()
        {
            
            
            if (instance == null)
            {
                lock (_lock){
                    if (instance == null)
                    {
                        return instance = new Singleton();
                    }
                }
            }
            return instance;
            
        }
    }
}