using System;

namespace StarbuzzVending
{
    public class Whip : BeverageCondiment 
    {
        public Whip( IBeverage aBeverage ) : base( aBeverage )
        {
        }

        public override string Description => Beverage.Description + ", Whip";

        public override double Cost() 
        {
            return 0.10 + Beverage.Cost();
        }
    }
}
