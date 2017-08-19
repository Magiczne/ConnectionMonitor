using System;
using System.IO;

namespace ConnectionMonitor.Writer
{
    internal class TxtWriter : IDataWriter
    {
        private readonly string _path;

        public TxtWriter()
        {
            _path = Path.Combine("Logs", $"{DateTime.Now:dd-MM-yyyy}", $"{DateTime.Now:hh-mm-ss}.txt");
        }

        public void WriteConnectionLost()
        {
            var message = $"[{DateTime.Now:d}] Connection Lost";
            File.AppendAllText(_path, message);
        }

        public void WriteConnectionRestored()
        {
            var message = $"[{DateTime.Now:d}] Connection Restored";
            File.AppendAllText(_path, message);
        }
    }
}