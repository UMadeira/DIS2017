using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas.Patterns.Observer2
{
    public delegate void UpdateHandler( object sender, object data );

    public interface ISubject
    {
        event UpdateHandler OnUpdate;
    }
}
