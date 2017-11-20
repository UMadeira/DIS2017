namespace DIS.Logging
{
    public class CounterDecorator : RecorderDecorator
    {
        private int Counter { get; set; }

        public CounterDecorator( IRecorder aRecorder ) : base( aRecorder )
        {
            Counter = 0;
        }

        #region IRecorder Members

        public override void Record( string aMessage )
        {
            Component.Record( $"{ ++Counter } : { aMessage }" );
        }

        #endregion
    }
}
