using System;
using System.Net;
using System.Timers;
using ConnectionMonitor.Writer;

namespace ConnectionMonitor.Monitor
{
    internal class ConnectionMonitor : IConnectionMonitor
    {
        /// <summary>
        /// Data Writer used to monitor changes
        /// </summary>
        private readonly IDataWriter _writer;

        /// <summary>
        /// Timer used to execute connection checking
        /// </summary>
        private readonly Timer _timer;

        /// <summary>
        /// Current connection status
        /// </summary>
        private ConnectionStatus _currentStatus;

        public ConnectionMonitor(IDataWriter writer)
        {
            _writer = writer;
            _timer = new Timer(5000);
            _timer.Elapsed += TimerTick;
        }

        /// <summary>
        /// Starts monitoring
        /// </summary>
        public void Start()
        {
            _writer.MonitoringStarted();
            _currentStatus = CheckConnection();
            _timer.Start();
        }

        /// <summary>
        /// Checks connection and invokes writer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="elapsedEventArgs"></param>
        private void TimerTick(object sender, ElapsedEventArgs elapsedEventArgs)
        {
            var status = CheckConnection();

            if (status == _currentStatus)
            {
                return;
            }

            _currentStatus = status;

            switch (_currentStatus)
            {
                case ConnectionStatus.Connected:
                    _writer.ConnectionRestored();
                    break;
                case ConnectionStatus.NotConnected:
                    _writer.ConnectionLost();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Checks for internet connections and returns status
        /// </summary>
        /// <returns>Internet connection is present</returns>
        public ConnectionStatus CheckConnection()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (client.OpenRead("http://clients3.google.com/generate_204"))
                    {
                        return ConnectionStatus.Connected;
                    }
                }
            }
            catch (WebException)
            {
                return ConnectionStatus.NotConnected;
            }
        }
    }
}
