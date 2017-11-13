namespace StarbuzzVending
{
    public abstract class BeverageCondiment : IBeverageCondiment
    {
        protected BeverageCondiment( IBeverage aBeverage )
        {
            Beverage = aBeverage;
        }

        public IBeverage Beverage { get; }

        #region IBeverage Members

        public abstract string Description { get; }

        public abstract double Cost();

        #endregion
    }
}
