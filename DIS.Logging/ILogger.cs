namespace DIS.Logging
{
    interface ILogger
    {
        IRecorder Recorder { get; set; }

        void Log( string aMessage );
    }
}
