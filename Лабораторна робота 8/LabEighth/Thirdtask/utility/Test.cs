using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thirdtask.model;

namespace Thirdtask.utility
{
    internal class FullTest
    {
        public static void CipherTest()
        {
            string[] texts = { "Aaaaaa", "Slovo", "Word", "Ninini", "Taktaktak" };

            ACipher[] aArray = new ACipher[texts.Length];
            BCipher[] bArray = new BCipher[texts.Length];

            for (int i = 0; i < texts.Length; i++)
            {
                aArray[i] = new ACipher(texts[i]);
                bArray[i] = new BCipher(texts[i]);
            }
            Array.Sort(aArray);
            Array.Sort(bArray);

            Console.WriteLine("\nACipher:");
            CipherTestPrinter.PrintSortedAndDecoded(aArray);

            Console.WriteLine("\nBCipher:");
            CipherTestPrinter.PrintSortedAndDecoded(bArray);
        }
    }
}

