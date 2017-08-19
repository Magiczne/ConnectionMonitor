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

        public void WriteConnectionLost()
        {
            var message = $"[{DateTime.Now:d}] Connection Lost";
            File.AppendAllText(Path, message);
        }

        public void WriteConnectionRestored()
        {
            var message = $"[{DateTime.Now:d}] Connection Restored";
            File.AppendAllText(Path, message);
        }
    }
}