using System.Globalization;
using System;
using System.Threading;
namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton instance;
        private static SpinLock mux = new SpinLock();
        private int zeroOrOne = 0;
        private Singleton() { }
        public static Singleton GetInstance()
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }
        public int FlipZeroOneField()
        {
            lock (this) return zeroOrOne == 0 ? ++zeroOrOne : zeroOrOne == 1 ? --zeroOrOne : zeroOrOne++;
        }
    }
}