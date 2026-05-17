using labTenth.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labTenth.Utility.test
{
    internal class ActionMethods
    {
        private DateTimeThings timePrinter = new DateTimeThings();
        public void Execute()
        {
            InformationPrinter.PrintHeader("Action:");
            timePrinter.OnlyTime();
            timePrinter.OnlyDate();
            timePrinter.DayOfWeek();
            Console.WriteLine();
        }
    }
}
