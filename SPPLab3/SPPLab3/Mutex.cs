using System.Threading;

namespace SPPLab3
{
    public class Mutex
    {
        private Thread lockingThread;

        public void Lock()
        {
            while (Interlocked.CompareExchange(ref lockingThread, Thread.CurrentThread, null) != null) {}
        }
        public void Unlock()
        {
            Interlocked.Exchange(ref lockingThread, null);
        }
    }
}
