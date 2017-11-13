namespace StarbuzzVending
{
    public class Decaf : Coffee
    {
        public override string Description => "Decaf";

        public override double Cost()
        {
            return 1.05;
        }
    }
}
