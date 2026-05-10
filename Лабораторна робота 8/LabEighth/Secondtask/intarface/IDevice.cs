using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secondtask.intarface
{
    internal interface IDevice<TElement>
    {
        string Name { get;}
        int Weight { get; }
        bool HaveEngineOrNot { get; }

        bool Electric { get; }
        decimal Price { get;  }
    }
}
