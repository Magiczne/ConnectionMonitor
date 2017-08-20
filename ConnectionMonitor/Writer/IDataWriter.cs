namespace ConnectionMonitor.Writer
{
    internal interface IDataWriter
    {
        /// <summary>
        ///     Writes connection lost information
        /// </summary>
        void ConnectionLost();

        /// <summary>
        ///     Writes connection restored information
        /// </summary>
        void ConnectionRestored();

        /// <summary>
        ///     Writed monitoring started information
        /// </summary>
        void MonitoringStarted();
    }
}