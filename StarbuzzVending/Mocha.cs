namespace StarbuzzVending
{
    public class Mocha : BeverageCondiment 
    {
        public Mocha( IBeverage aBeverage ) : base( aBeverage )
        {
        }

        public override string Description => Beverage.Description + ", Mocha";

        public override double Cost() 
        {
            return 0.20 + Beverage.Cost();
        }
    }
}
