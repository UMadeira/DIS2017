namespace StarbuzzVending
{
    public class Soy : BeverageCondiment 
    {
        public Soy( IBeverage aBeverage ) : base( aBeverage )
        {
        }

        public override string Description => Beverage.Description + ", Soy";

        public override double Cost() 
        {
            return 0.15 + Beverage.Cost();
        }
    }
}
