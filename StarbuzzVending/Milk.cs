using System;

namespace StarbuzzVending
{
    public class Milk : BeverageCondiment 
    {
        public Milk( IBeverage aBeverage ) : base( aBeverage )
        {
        }

        public override String Description => Beverage.Description + ", Milk";

        public override double Cost() 
        {
            return 0.10 + Beverage.Cost();
        }
    }
}
