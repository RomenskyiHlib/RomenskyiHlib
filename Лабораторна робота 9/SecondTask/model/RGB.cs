using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask.model
{
    internal struct RGB
    {
        private byte[] rgb;
        public byte red; 
        public byte green; 
        public byte blue;
        public byte[] Information(byte red, byte green, byte blue) 
        { 
            this.red = red; 
            this.green = green;
            this.blue = blue;   
            return rgb = new byte[]{red, green, blue}; 
        }
        public RGB(byte Red, byte Green, byte Blue)
        {
            red = Red;
            green = Green;
            blue = Blue;
        }
        public string ToHex()
        {
            return $"#{red:X2}{green:X2}{blue:X2}";
        }

        public (double Cyan, double Magenta, double Yellow, double Key) ToCmyk()
        {
            if (red == 0 && green == 0 && blue == 0)
                return (0, 0, 0, 1);

            double r = red / 255.0;
            double g = green / 255.0;
            double b = blue / 255.0;

            double k = 1 - (r > g ? r > b ? r : b: g > b ? g : b);
            double c = (1 - r - k) / (1 - k);
            double m = (1 - g - k) / (1 - k);
            double y = (1 - b - k) / (1 - k);

            return (Math.Round(c, 2), Math.Round(m, 2), Math.Round(y, 2), Math.Round(k, 2));
        }

        public (double H, double S, double L) ToHsl()
        {
            double r = red / 255.0;
            double g = green / 255.0;
            double b = blue / 255.0;

            double max = r > g ? r > b ? r : b : g > b ? g : b;
            double min = r < g ? r < b ? r : b : g < b ? g : b;
            double h;
            double s;
            double l = (max + min) / 2.0;

            if (max == min)
            {
                h = s = 0; 
            }
            else
            {
                double d = max - min;
                s = l > 0.5 ? d / (2.0 - max - min) : d / (max + min);

                if (max == r)
                    h = (g - b) / d + (g < b ? 6 : 0);
                else if (max == g)
                    h = (b - r) / d + 2;
                else
                    h = (r - g) / d + 4;

                h /= 6.0;
            }

            return (Math.Round(h * 360), Math.Round(s * 100), Math.Round(l * 100));
        }

    }
}
