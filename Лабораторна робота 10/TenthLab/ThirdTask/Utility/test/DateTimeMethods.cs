using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdTask.Service;

namespace ThirdTask.Utility.test
{
    internal class DateTimeMethods
    {
        private DateTimeThings dateService = new DateTimeThings();

        public void Execute()
        {
           InformationPrinter.PrintHeader("Datetime:");

            DateTime dateToTest = MakeData.GetOrProgrammerDate();

            bool isProgrammerDay = dateService.IsProgrammerDay(dateToTest);

            InformationPrinter.PrintDateResult(dateToTest, isProgrammerDay);
        }
    }
}
