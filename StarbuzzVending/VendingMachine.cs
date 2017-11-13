
using System;

namespace StarbuzzVending
{
    public class VendingMachine
    {
        public IBeverage Order( string aOrder )
        {
            var beverage = BeverageFactory.Instance.CreateBeverage( aOrder );
            return beverage;
        }

        public void Prepare( IBeverage aBeverage )
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        protected virtual void Brew()
        {
            
        }

        protected virtual void AddCondiments()
        {
            
        }

        protected virtual void BoilWater()
        {
            Console.WriteLine( "Boiling water." );
        }

        protected virtual void PourInCup()
        {
            Console.WriteLine( "Pouring into cup." );
        }

    }
}
