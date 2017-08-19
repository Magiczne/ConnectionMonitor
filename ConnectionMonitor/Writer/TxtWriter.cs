using System;
using System.IO;

namespace ConnectionMonitor.Writer
{
    internal class TxtWriter : IDataWriter
    {
        public string Path { get; }

        public TxtWriter()
        {
            Path = System.IO.Path.Combine("Logs", $"{DateTime.Now:dd-MM-yyyy}", $"{DateTime.Now:hh-mm-ss}.txt");
        }

        public void ConnectionLost()
        {
            var message = $"[{DateTime.Now:d}] Connection Lost";
            File.AppendAllText(Path, message);
        }

        public void ConnectionRestored()
        {
            var message = $"[{DateTime.Now:d}] Connection Restored";
            File.AppendAllText(Path, message);
        }

        public void MonitoringStarted()
        {
            var message = $"[{DateTime.Now:d}] Monitoring started";
            File.AppendAllText(Path, message);
        }
    }
}