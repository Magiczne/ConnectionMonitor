using System;

namespace ConnectionMonitor.Writer
{
    internal class ConsoleWriter : IDataWriter
    {
        /// <summary>
        ///     Writes connection lost information into console
        /// </summary>
        public void ConnectionLost()
        {
            Console.WriteLine();
            Console.WriteLine($"[{DateTime.Now:hh:mm:ss}] Connection Lost");
        }

        /// <summary>
        ///     Writes connection restored information into console
        /// </summary>
        public void ConnectionRestored()
        {
            Console.WriteLine($"[{DateTime.Now:hh:mm:ss}] Connection Restored");
            Console.WriteLine();
        }

        /// <summary>
        ///     Writed monitoring started information into console
        /// </summary>
        public void MonitoringStarted()
        {
            Console.WriteLine($"[{DateTime.Now:hh:mm:ss}] Monitoring started");
        }
    }
}