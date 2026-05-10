using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdTask.model;

namespace LabNinth.utility
{
    internal class ArmoryGenerate
    {
        private static Random random = new Random();

        public static Item CreateRandomItem()
        {
                string[] names = { "Sword", "Bow", "Axe", "Armor", "Helmet", "Dagger", "Shield" };

                ArmorCategory[] categories = (ArmorCategory[])Enum.GetValues(typeof(ArmorCategory));

                return new Item(
                    names[random.Next(names.Length)],
                    categories[random.Next(categories.Length)],
                    random.Next(1, 10),
                    random.Next(50, 500)
                    
                );
            }
      
        }
    }

