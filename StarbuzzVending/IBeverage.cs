namespace StarbuzzVending
{
    public interface IBeverage
    {
        // Properties
        string Description { get; }

        // Methods
        double Cost();
    }
}