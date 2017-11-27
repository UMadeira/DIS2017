namespace Christmas.Patterns.Observer
{
    public interface IObserver
    {
        void Update( object aSender, object aData );
    }
}
