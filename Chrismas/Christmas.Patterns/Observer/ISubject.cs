namespace Christmas.Patterns.Observer
{
    public interface ISubject
    {
        void Attach( IObserver aObserver );
        void Detach( IObserver aObserver );

        void Notify( object aSender, object aData );
    }
}
