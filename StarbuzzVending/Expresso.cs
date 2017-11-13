namespace StarbuzzVending
{
    public class Expresso : Coffee 
    {
        public override string Description => "Expresso";

        public override double Cost() 
        {
            return 1.99;
        }
    }
}
