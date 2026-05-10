using Secondtask.model.devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secondtask.service
{
    internal class RegisterPrinter
    {
        public static void PrintAll(Devices[] devices)
        {
            foreach (var device in devices) 
                Console.WriteLine(device);
        }
        public void ShowElectronic(Devices[] listOfDevices)
        {
            foreach (var device in listOfDevices)
            {
                if (device.Electric)
                    Console.WriteLine(device);
            }
        }

        public void ShowNoEngine(Devices[] listOfDevices)
        {
            foreach (var device in listOfDevices)
            {
                if (!device.HaveEngineOrNot)
                    Console.WriteLine(device);
            }
        }
    }
}
