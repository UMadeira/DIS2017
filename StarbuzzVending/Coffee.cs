using System;

namespace StarbuzzVending
{
    public abstract class Coffee : IBeverage
    {
        public abstract string Description { get; }
        public abstract double Cost();
    }
}
