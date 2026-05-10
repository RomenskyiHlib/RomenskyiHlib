using Secondtask.model.devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secondtask.service
{
    internal class RegisterSorter
    {
        public static void SortByName(Devices[] listOfDevices)
        {
            Array.Sort(listOfDevices);
        }

        public static void SortByEnginePresence(Devices[] listOfDevices)
        {
            Array.Sort(listOfDevices, (x, y) => x.HaveEngineOrNot.CompareTo(y.HaveEngineOrNot));
        }
    }
}
