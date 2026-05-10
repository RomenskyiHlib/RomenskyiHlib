using Secondtask.model.devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secondtask.utility
{
    internal static class DevicesGenerator
    {
        private static Random random = new Random();
        private static string[] names = { "Nazva1", "Nazva2", "Nazva3", "Nazva4", "Nazva5" };

        public static Devices GenerateRandomDevice()
        {
            int type = random.Next(5);
            string name = $"{names[random.Next(names.Length)]}-{random.Next(100, 999)}";
            int weight = random.Next(50, 5000);
            decimal price = random.Next(1000, 50000);
            int power = random.Next(50, 2000);

            return type switch
            {
                0 => new Airplane(name, weight, price, power),
                1 => new HangGlider(name, weight, price), 
                2 => new HotAirBalloon(name, weight, price),
                3 => new Helicopter(name, weight, price, power),
                4 => new FlyCarpet(name, weight, price)
            };
        }
    }
}
