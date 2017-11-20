using System.Diagnostics;

namespace DIS.Logging
{
    public class TraceRecorder : IRecorder
    {
        public void Record( string aMessage )
        {
            Trace.WriteLine( aMessage );
        }
    }
}
