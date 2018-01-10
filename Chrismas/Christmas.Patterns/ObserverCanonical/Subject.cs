using System.Collections.Generic;

namespace Christmas.Patterns.ObserverCanonical
{
    public class Subject : ISubject
    {
        private IList<IObserver> Observers { get; } = new List<IObserver>();

        public void Attach( IObserver aObserver )
        {
            if ( Observers.Contains( aObserver ) ) return;
            Observers.Add( aObserver );
        }

        public void Detach( IObserver aObserver )
        {
            if ( ! Observers.Contains( aObserver ) ) return;
            Observers.Remove( aObserver );
        }

        public void Notify( object aSender = null, object aData = null )
        {
            foreach ( var observer in Observers )
            {
                observer.Update( aSender, aData );
            }
        }
    }
}
