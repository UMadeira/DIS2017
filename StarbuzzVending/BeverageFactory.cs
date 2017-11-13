namespace StarbuzzVending
{
    public sealed class BeverageFactory
    {
        #region Singleton | Usage: BeverageFactory.Instance
        static BeverageFactory()
        {
        }

        private BeverageFactory() 
        {
        }

        public static BeverageFactory Instance { get; } = new BeverageFactory();
        #endregion

        public IBeverage CreateBeverage( string aBeverage )
        {
            IBeverage beverage = null;

            string[] parts = aBeverage.Split('+');

            // Create Beverage
            switch ( parts[0].Trim().ToUpper() )
            {
                case "HOUSEBLEND":
                    beverage = new HouseBlend();
                    break;
                case "DARKROAST":
                    beverage = new DarkRoast();
                    break;
                case "DECAF":
                    beverage = new Decaf();
                    break; 
                case "EXPRESSO":
                    beverage = new Expresso();
                    break; 
                case "TEA":
                    beverage = new Tea();
                    break; 
            }

            // Create Condiments
            for ( int i = 1 ; i < parts.Length ; i++ )
            {
                switch ( parts[i].Trim().ToUpper() )
                {
                    case "MILK":
                        beverage = new Milk(beverage);
                        break;
                    case "MOCHA":
                        beverage = new Mocha(beverage);
                        break;
                    case "SOY":
                        beverage = new Soy(beverage);
                        break;
                    case "WHIP":
                        beverage = new Whip(beverage);
                        break;
                }
            }

            return beverage;
        }
    }
}
