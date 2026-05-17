using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask.Service
{
    internal class TextThings
    {
        public Func<string, string, bool> ContainsWord =>
            (text, word) => text.Contains(word, StringComparison.OrdinalIgnoreCase);
    }
}
