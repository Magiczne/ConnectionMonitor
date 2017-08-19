using System;
using System.IO;

namespace ConnectionMonitor.Writer
{
    internal class TxtWriter : IDataWriter
    {
        public string FilePath { get; }

        public TxtWriter()
        {
            var dir = Path.Combine("Logs", $"{DateTime.Now:dd-MM-yyyy}");

            FilePath = Path.Combine(dir, $"{DateTime.Now:hh-mm-ss}.txt");

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            if (!File.Exists(FilePath))
            {
                File.Create(FilePath).Close();
            }
        }

        public void ConnectionLost()
        {
            var message = $"[{DateTime.Now:d}] Connection Lost";
            File.AppendAllText(FilePath, message);
        }

        public void ConnectionRestored()
        {
            var message = $"[{DateTime.Now:d}] Connection Restored";
            File.AppendAllText(FilePath, message);
        }

        public void MonitoringStarted()
        {
            var message = $"[{DateTime.Now:d}] Monitoring started";
            File.AppendAllText(FilePath, message);
        }
    }
}