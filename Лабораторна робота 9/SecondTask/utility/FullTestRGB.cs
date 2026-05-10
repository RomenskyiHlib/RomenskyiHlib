using SecondTask.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask.utility
{
    internal class FullTestRGB
    {
        public static void RGBTest()
        {
            RGB rgb = new RGB();

            byte r = 15;
            byte g = 0;
            byte b = 10;
            rgb.Information(r, g, b);

            Console.WriteLine($"RGB: {r}.{g}.{b}");
            Console.WriteLine($"Hex: {rgb.ToHex()}");
            Console.WriteLine($"CMYK: {rgb.ToCmyk().Magenta},{rgb.ToCmyk().Cyan},{rgb.ToCmyk().Yellow},{rgb.ToCmyk().Key}");
            Console.WriteLine($"HSL: {rgb.ToHsl().H},{rgb.ToHsl().S},{rgb.ToHsl().L}");
        }
    }
}
