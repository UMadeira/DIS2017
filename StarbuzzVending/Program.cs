using System;

namespace StarbuzzVending
{
    class Program
    {
        static void Main( string[] args )
        {
            VendingMachine machine = new VendingMachine();

            Console.WriteLine("Starbuzz Vending Machine");
            Console.WriteLine();
            Console.Write( "Select Beverage: " );
            var beverage = machine.Order( Console.ReadLine() );
            if ( beverage != null )
            {
                Console.WriteLine(  "> {0} : cost {1} euros", beverage.Description, beverage.Cost() );
            }
            else
            {
                Console.WriteLine(  "> The requested drink cannot be served." );
            }
            Console.WriteLine();
            Console.WriteLine( "Press any key to continue." );
            Console.ReadKey();
        }
    }
}
