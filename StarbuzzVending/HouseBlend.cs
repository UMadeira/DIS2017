namespace StarbuzzVending
{
    class HouseBlend : Coffee
    {
        public override string Description => "HouseBlend";

        public override double Cost()
        {
            return 0.89;
        }
    }
}
