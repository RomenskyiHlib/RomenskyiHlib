using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    internal class Student
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int gradeBook { get; set; }
        public int number { get; set; }

        public const int numberOfSubjects = 7;
        Subject[] subjects = new Subject[numberOfSubjects];

        public Student(int id, string firstName, string lastName, int gradeBook, int number)
        {
            Id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.gradeBook = gradeBook;
            this.number = number;
        }

        public int AveragePerformance
        {
            get
            {
                int allAssessment = 0; int numberOfAssessment = 0; foreach (var subject in subjects)
                {
                    allAssessment += subject.assessment;
                }
                return allAssessment / numberOfAssessment;
            }
        }

        public int BestAssessment
        {
            get
            {
                int max = 0; for (int i = 0; i < numberOfSubjects; i++)
                {
                    if (subjects[i].assessment > max)
                    {
                        max = subjects[i].assessment;
                    }
                } 
                return max;

            }
        }
        public int WorstAssessment
        {
            get
            {
                int min = 0; for (int i = 0; i < numberOfSubjects; i++)
                {
                    if (subjects[i].assessment < min && i == 0)
                    {
                        min = subjects[i].assessment;
                    }
                }
                return min;

            }
        }
    }
}
