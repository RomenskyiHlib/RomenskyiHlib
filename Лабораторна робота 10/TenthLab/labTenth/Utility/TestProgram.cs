using labTenth.Utility.test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labTenth.Utility
{
    internal class TestProgram
    {
        public static void FullTest()
        {
            new ActionMethods().Execute();
            new PredicateMethods().Execute();
            new FuncMethods().Execute();
        }
    }
}
