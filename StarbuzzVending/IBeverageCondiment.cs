namespace StarbuzzVending
{
    interface IBeverageCondiment : IBeverage
    {
        IBeverage Beverage { get; }
    }
}
