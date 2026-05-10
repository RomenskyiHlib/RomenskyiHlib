using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdTask.model;

namespace ThirdTask.utility
{
    internal class ArmoryPrinter
    {
        public static void Print(Armory armory)
        {
            for (int i = 0; i < armory.count; i++)
            {
                Console.WriteLine(armory.items[i].ToString());
            }
        }
    }
}
