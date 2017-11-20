namespace DIS.Logging
{
    public abstract class RecorderDecorator : IRecorder
    {
        protected IRecorder Component { get; set; }

        protected RecorderDecorator( IRecorder aRecorder )
        {
            Component = aRecorder;
        }

        public abstract void Record( string aMessage );
    }
}
