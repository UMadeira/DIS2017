using System;

namespace StarbuzzVending
{
    public abstract class CaffeineBeverage : IBeverage
    {
        #region IBeverage Members

        public abstract string Description { get; }

        public abstract double Cost();

        #endregion
    }
}
