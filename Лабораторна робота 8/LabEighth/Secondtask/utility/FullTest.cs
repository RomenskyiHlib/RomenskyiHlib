using Labeighth.second;
using Microsoft.Win32;
using Secondtask.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secondtask.utility
{
    internal static class FullTest
    {
        public static void Test()
        {
            Register register = new Register();

            for (int i = 0; i < Register.size; i++)
            {
                var device = DevicesGenerator.GenerateRandomDevice();
                register.Create(device);
                Console.WriteLine($"Add: {device.Name} ({device.GetType().Name})");
            }

            Console.WriteLine("\nSort");
            RegisterSorter.SortByName(register.listOfDevices);
            RegisterPrinter.PrintAll(register.listOfDevices);

            Console.WriteLine("\nDelete the element");
            if (register.listOfDevices.Length > 0 || register.listOfDevices[0] != null)
            {
                string nameToDelete = register.listOfDevices[0].Name;
                register.Delete(nameToDelete);
                Console.WriteLine($"Delete: {nameToDelete}");
                Console.WriteLine($"Left elements: {register.listOfDevices.Length}");
            }
        }

    }
}
