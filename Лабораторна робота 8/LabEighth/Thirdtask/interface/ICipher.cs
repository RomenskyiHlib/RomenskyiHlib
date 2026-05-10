using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thirdtask.@interface
{
    internal interface ICipher
    {
        string Encode(string input);
        string Decode(string input);
        string Text { get; set; }
    }
}
