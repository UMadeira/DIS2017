namespace Christmas.Patterns.Observer
{
    public delegate void UpdateHandler( object sender, object data );

    public interface ISubject
    {
        event UpdateHandler OnUpdate;
    }
}
