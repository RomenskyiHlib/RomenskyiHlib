using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdTask.Utility.test;

namespace ThirdTask.Utility
{
    internal class TestProgram
    {
        public static void FullTest()
        {
            new ArrayMethods().Execute();
            new DateTimeMethods().Execute();
            new TextMethods().Execute();
        }
    }
}

