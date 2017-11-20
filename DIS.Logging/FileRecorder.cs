using System.IO;

namespace DIS.Logging
{
    public class FileRecorder : IRecorder
    {
        private StreamWriter Stream { get; }

        public FileRecorder( string aFileName )
        {
            Stream = new StreamWriter( aFileName ) { AutoFlush = true };
        }

        #region IRecorder Members

        public void Record( string aMessage )
        {
            Stream.WriteLine( aMessage );
        }

        #endregion

    }
}
