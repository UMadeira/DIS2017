namespace StarbuzzVending
{
    public class DarkRoast : Coffee
    {
        public override string Description => "DarkRoast";

        public override double Cost()
        {
            return 0.99;
        }
    }
}
