using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdTask.Service;

namespace ThirdTask.Utility.test
{
    internal class TextMethods
    {
        private readonly TextThings text = new TextThings();

        public void Execute()
        {
            InformationPrinter.PrintHeader("Text:");

            string sampleText = "The world tried to catch me, but it didn't";
            string[] searchWords = { "to", "SOLID", "me" };

            InformationPrinter.PrintInitialText(sampleText);

            foreach (var word in searchWords)
            {
                bool hasWord = text.ContainsWord(sampleText, word);

                InformationPrinter.PrintTextResult(sampleText, word, hasWord);
            }
        }
    }
}
