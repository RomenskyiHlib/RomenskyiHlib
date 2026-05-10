using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdTask.model;
using ThirdTask.utility;

namespace LabNinth.utility
{
    internal class TestMethods
    {
        public static void Test()
        {
            int size = 5;
            Armory armory = new Armory(size);
            
            for (int i = 0; i < size; i++)
            {
                armory.Create(ArmoryGenerate.CreateRandomItem());
            }
            var item = armory.Read("Sword");
            Console.WriteLine("Create:");
            ArmoryPrinter.Print(armory);

            armory.Update("Sword", new Item("Sword", ArmorCategory.meleeWeapon, 1, 120));

            Console.WriteLine("\nUpdate");
            ArmoryPrinter.Print(armory);

            armory.Delete("Bow");

            Console.WriteLine("\nDelete");
            ArmoryPrinter.Print(armory);
        }
    }
}
