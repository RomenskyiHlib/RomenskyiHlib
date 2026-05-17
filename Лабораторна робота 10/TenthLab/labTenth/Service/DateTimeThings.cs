using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labTenth.Service
{
    internal class DateTimeThings
    {
        public Action OnlyTime => () => Console.WriteLine($"Time now: {DateTime.Now:HH:mm:ss}");
        public Action OnlyDate => () => Console.WriteLine($"Date now: {DateTime.Now:dd.MM.yyyy}");
        public Action DayOfWeek => () => Console.WriteLine($"Day Of Week now: {DateTime.Now.DayOfWeek}");
    }
}

