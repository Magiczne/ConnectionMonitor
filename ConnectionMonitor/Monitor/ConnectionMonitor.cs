using System.Net;

namespace ConnectionMonitor.Monitor
{
    internal class ConnectionMonitor : IConnectionMonitor
    {
        public bool CheckConnection()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (client.OpenRead("http://clients3.google.com/generate_204"))
                    {
                        return true;
                    }
                }
            }
            catch (WebException)
            {
                return false;
            }
        }
    }
}
