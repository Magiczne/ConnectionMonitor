using System;
using System.IO;

namespace ConnectionMonitor.Writer
{
    internal class TxtWriter : IDataWriter
    {
        public TxtWriter()
        {
            var dir = Path.Combine("Logs", $"{DateTime.Now:dd-MM-yyyy}");

            FilePath = Path.Combine(dir, $"{DateTime.Now:hh-mm-ss}.txt");

            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            if (!File.Exists(FilePath))
                File.Create(FilePath).Close();
        }

        /// <summary>
        ///     Path of the log file being used
        /// </summary>
        public string FilePath { get; }

        /// <summary>
        ///     Writes connection lost information into the file
        /// </summary>
        public void ConnectionLost()
        {
            var message = $"[{DateTime.Now:hh:mm:ss}] Connection Lost{Environment.NewLine}";
            File.AppendAllText(FilePath, message);
        }

        /// <summary>
        ///     Writes connection restored information into the file
        /// </summary>
        public void ConnectionRestored()
        {
            var message = $"[{DateTime.Now:hh:mm:ss}] Connection Restored{Environment.NewLine}";
            File.AppendAllText(FilePath, message);
        }

        /// <summary>
        ///     Writed monitoring started information into the file
        /// </summary>
        public void MonitoringStarted()
        {
            var message = $"[{DateTime.Now:hh:mm:ss}] Monitoring started{Environment.NewLine}";
            File.AppendAllText(FilePath, message);
        }
    }
}