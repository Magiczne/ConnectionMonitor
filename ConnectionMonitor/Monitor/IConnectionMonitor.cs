namespace ConnectionMonitor.Monitor
{
    internal interface IConnectionMonitor
    {
        /// <summary>
        ///     Checks for internet connections and returns status
        /// </summary>
        /// <returns>Internet connection is present</returns>
        ConnectionStatus CheckConnection();

        /// <summary>
        ///     Starts monitoring
        /// </summary>
        void Start();
    }
}