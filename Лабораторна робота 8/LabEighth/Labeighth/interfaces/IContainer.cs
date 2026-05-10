using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Labeighth.interfaces
{
    internal interface IContainer<TElement>
    {
        int Count { get; }
        object this[int index] { get; set; }
        void Add(TElement element);
        void Delete(TElement element);
    }
}
