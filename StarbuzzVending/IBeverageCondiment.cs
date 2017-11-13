using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbuzzVending
{
    interface IBeverageCondiment : IBeverage
    {
        IBeverage Beverage { get; }
    }
}
