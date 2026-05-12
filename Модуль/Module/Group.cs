using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    internal class Group
    {
        Student[] group = new Student[5];

        public bool this[Student firstName]
        {
            get
            {
                if (firstName == firstName)
                    return true;
                else return false;
            }
        }

        public string BestStudent {


            get
            {
                string bestStudent = " ";
                int max = 0; for (int i = 0; i < 5; i++)
                {
                    if (group[i].AveragePerformance > max)
                    {
                        max = group[i].AveragePerformance;
                        bestStudent = group[i].firstName + " " + group[i].lastName;
                    }
                }
                return bestStudent;
            }
    }
}
