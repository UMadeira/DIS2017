using System.Diagnostics;

namespace DIS.Logging
{
    public class EventLogRecorder : IRecorder
    {
        public EventLogRecorder( string aApplicationName, string aLog = "Application" )
        {
            if ( ! EventLog.SourceExists( aApplicationName ) )
            {
                EventLog.CreateEventSource( aApplicationName, aLog );
            }

            EventLog.Source = aApplicationName;
            EventLog.Log = aLog;
        }

        private EventLog EventLog { get; } = new EventLog();

        private int EventId { get; set; }

        public void Record( string aMessage )
        {
            if ( string.IsNullOrEmpty( aMessage ) ) return;
            EventLog.WriteEntry( aMessage, EventLogEntryType.Warning, ++EventId );
        }
    }
}
