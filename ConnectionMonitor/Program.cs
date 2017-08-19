using System;
using ConnectionMonitor.Writer;

namespace ConnectionMonitor
{
    internal class Program
    {
        private static void Main()
        {
            var writer = new TxtWriter();
            var monitor = new Monitor.ConnectionMonitor(writer);

            Console.WriteLine("Connection Monitor");
            Console.WriteLine("Starting monitoring at {0:g}", DateTime.Now);
            Console.WriteLine("Writing to file: {0}", writer.Path);
            Console.WriteLine();
            Console.WriteLine("Press any key to stop monitoring");

            monitor.Start();

            Console.ReadKey(true);
        }
    }
}