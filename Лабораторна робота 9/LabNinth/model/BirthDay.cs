using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LabNinth.model
{
    internal struct Birthday
    {
        private DateOnly birthDate;
        public DateOnly Information(int day, int mouth, int year) { return birthDate = new DateOnly(year, mouth, day); }
        public DayOfWeek DayOfWeek() { return birthDate.DayOfWeek; }
        public DayOfWeek WhichDayInYear(int year)
        {
            DateOnly futureDate = new DateOnly(year, birthDate.Month, birthDate.Day);
            return futureDate.DayOfWeek;
        }
        public int DaysUntilNextBirthday()
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.Today);

            DateOnly nextBirthday = new DateOnly(today.Year, birthDate.Month, birthDate.Day);

            if (nextBirthday <= today)
            {
                nextBirthday = new DateOnly(today.Year + 1, birthDate.Month, birthDate.Day);
            }

            return nextBirthday.DayNumber - today.DayNumber;
        }
    }
}
