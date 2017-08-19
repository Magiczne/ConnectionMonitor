namespace ConnectionMonitor.Writer
{
    internal interface IDataWriter
    {
        /// <summary>
        /// Writes connection lost information into the file
        /// </summary>
        void ConnectionLost();

        /// <summary>
        /// Writes connection restored information into the file
        /// </summary>
        void ConnectionRestored();

        /// <summary>
        /// Writed monitoring started information into the file
        /// </summary>
        void MonitoringStarted();
    }
}
