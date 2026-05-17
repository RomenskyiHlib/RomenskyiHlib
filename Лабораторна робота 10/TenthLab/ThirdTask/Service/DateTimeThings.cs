using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask.Service
{
    internal class DateTimeThings
    {
        public Func<DateTime, bool> IsProgrammerDay =>
            date => date.DayOfYear == 256;
    }
}
