using Secondtask.intarface;
using Secondtask.model.devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labeighth.second
{
    internal class Register
    {
        public const int size = 7;
        public Devices[] listOfDevices = new Devices[size];
        private int count;

        public Devices[] Devices
        {
            get
            {
                Devices[] activeDevices = new Devices[count];
                for (int i = 0; i < count; i++)
                {
                    activeDevices[i] = listOfDevices[i];
                }
                return activeDevices;
            }
        }
        public override string ToString()
        {
            string devices = " ";
            foreach (var device in listOfDevices)
            {
                devices += " " + device; 
            }
            return $"Devices: {devices}";
        }


        public void AddDevice(Devices device)
        {
            Devices[] newArray = new Devices[listOfDevices.Length + 1];

            for (int i = 0; i < listOfDevices.Length; i++)
            {
                newArray[i] = listOfDevices[i];
            }

            newArray[newArray.Length - 1] = device;

            listOfDevices = newArray;
        }
        public void Create(Devices device)
        {
            if (count < listOfDevices.Length)
            {
                listOfDevices[count] = device;
                count++;
            }
            else
            {
                Console.WriteLine("Already full!");
            }
        }

        public Devices Read(string name)
        {
            if (listOfDevices == null) return null;

            foreach (var d in listOfDevices)
            {
                if (d.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                    return d;
            }
            return null;
        }

        public bool Update(string oldName, Devices newDevice)
        {
            for (int i = 0; i < count; i++) 
            {
                if (listOfDevices[i] != null && listOfDevices[i].Name == oldName)
                {
                    listOfDevices[i] = newDevice;
                    return true;
                }
            }
            return false;
        }

        public bool Delete(string name)
        {
            for (int i = 0; i < count; i++)
            {
                if (listOfDevices[i].Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
   
                    for (int j = i; j < count - 1; j++)
                    {
                        listOfDevices[j] = listOfDevices[j + 1];
                    }
                    listOfDevices[count - 1] = null; 
                    count--;
                    return true;
                }
            }
            return false;
        }
    }
}

