using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask.Utility
{
    internal static class MakeData
    {
            private static Random random = new Random();

            public static int[] GenerateArray(int size, int min, int max)
            {
                return Enumerable.Range(0, size).Select(_ => random.Next(min, max)).ToArray();
            }

            public static DateTime GetOrProgrammerDate()
            {
                int currentYear = DateTime.Now.Year;
                if (random.Next(0, 2) == 0)
                {
                    return new DateTime(currentYear, 1, 1).AddDays(255);
                }
                return new DateTime(currentYear, 1, 1).AddDays(random.Next(0, 365));
            }
        }
    }

