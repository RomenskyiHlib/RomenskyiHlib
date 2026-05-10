using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdTask.model;

namespace ThirdTask.interfaces
{
    internal interface IArmory
    {
         void Create(Item item);
         void Add(Item item);
         bool Delete(string Name);
         bool Update(string oldName, Item newItem);
         Item[] GetAll();
        
    }
}
