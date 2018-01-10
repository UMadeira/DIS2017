namespace Christmas.Patterns.ObserverCanonical
{
    public interface IObserver
    {
        void Update( object aSender, object aData );
    }
}
