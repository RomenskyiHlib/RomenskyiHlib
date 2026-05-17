using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labTenth.Utility
{
    internal class MakeData
    {
            private static Random random = new Random();
            public static int GetIntNum(int min, int max) => random.Next(min, max);
            public static double GetDoubleNum(double min, double max) => random.NextDouble() * (max - min) + min;
            public static int GetFibonacciNum()
            {
                int[] knownFibonacci = { 0, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };
                return knownFibonacci[random.Next(knownFibonacci.Length)];
            }
        }
    }

