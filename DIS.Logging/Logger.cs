namespace DIS.Logging
{
    public sealed class Logger : ILogger
    {
        #region Singleton - usage: Logger.Instance 

        static Logger()
        {
        }
        
        private Logger()
        {
        }

        public static Logger Instance { get; } = new Logger();

        #endregion

        #region ILogger Members

        public IRecorder Recorder { get; set; }

        public void Log( string aMessage )
        {
            Recorder?.Record( aMessage );
        }

        #endregion
    }
}
