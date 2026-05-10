using LabNinth.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNinth.utility
{
    internal class FullTest
    {
        public static void MakeBirthday()
        {
            Birthday bday = new Birthday();

            int day = 15;
            int month = 5;
            int year = 2000;
            bday.Information(15, month, year);

            Console.WriteLine($"Date: {day}.{month}.{year}");

            Console.WriteLine($"Day of week: {bday.DayOfWeek()}");

            int checkYear = 2030;
            Console.WriteLine($"In {checkYear} year birthdate will be in this day: {bday.WhichDayInYear(checkYear)}");
            int daysLeft = bday.DaysUntilNextBirthday();
            Console.WriteLine($"Days Until Next Birthday: {daysLeft}");
        }
    }
}

