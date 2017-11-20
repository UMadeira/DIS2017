using System;

namespace DIS.Logging
{
    public class DateDecorator : RecorderDecorator
    {
        public DateDecorator( IRecorder aRecorder ) : base( aRecorder ) { }

        public override void Record( string aMessage )
        {
            var dateinfo = DateTime.Now.ToString( "yyyy-mm-dd" ) + " " + DateTime.Now.ToLongTimeString();
            Component.Record( $"{ dateinfo } : { aMessage }" );
        }
    }
}
