using System;

namespace ConnectionMonitor.Writer
{
    internal class ConsoleWriter : IDataWriter
    {
        public void ConnectionLost()
        {
            Console.WriteLine();
            Console.WriteLine($"[{DateTime.Now:hh:mm:ss}] Connection Lost");
        }

        public void ConnectionRestored()
        {
            Console.WriteLine($"[{DateTime.Now:hh:mm:ss}] Connection Restored");
            Console.WriteLine();
        }

        public void MonitoringStarted()
        {
            Console.WriteLine($"[{DateTime.Now:hh:mm:ss}] Monitoring started");
        }
    }
}