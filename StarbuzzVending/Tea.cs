using System;

namespace StarbuzzVending
{
    public class Tea : IBeverage
    {
        public string Description => "Tea";

        public double Cost()
        {
            return 1.0;
        }
    }
}
