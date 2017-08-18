namespace ConnectionMonitor.Writer
{
    internal interface IDataWriter
    {
        void WriteConnectionLoss();

        void WriteConnectionRestore();
    }
}
