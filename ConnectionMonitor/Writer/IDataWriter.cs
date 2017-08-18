namespace ConnectionMonitor.Writer
{
    internal interface IDataWriter
    {
        /// <summary>
        /// Writes connection lost information into the file
        /// </summary>
        void WriteConnectionLost();

        /// <summary>
        /// Writes connection restored information into the file
        /// </summary>
        void WriteConnectionRestored();
    }
}
