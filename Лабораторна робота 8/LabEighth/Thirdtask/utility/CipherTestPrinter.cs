using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thirdtask.@interface;

namespace Thirdtask.utility
{
    internal class CipherTestPrinter
    {
        public static void PrintSortedAndDecoded(object[] ciphers)
        {
            foreach (var obj in ciphers)
            {
                if (obj is ICipher cipher)
                {

                    string original = cipher.Text;

                    Console.WriteLine(cipher.Encode(original));
                    Console.WriteLine(cipher.Decode(cipher.Encode(original)));
                }
            }
        }
    }
}