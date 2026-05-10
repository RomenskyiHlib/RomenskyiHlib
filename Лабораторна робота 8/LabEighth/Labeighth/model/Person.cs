using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labeighth.first
{
    internal class Person : IComparable, ICloneable
    {
        private string firstName;
        private string lastName;
        private DateTime birthDate;

        private static DateTime minBirthDate = new(1900, 01, 01);


        public Person(string firstName, string lastName, DateTime birthDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
        }

        public Person()
        {
            firstName = "Im'ia";
            lastName = "Pryzvyshche";
            birthDate = new DateTime(2000, 08, 20);

        }
        public string FirstName
        {
            get { return firstName; }
            set { if (value != null) firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { if (value != null) lastName = value; }
        }
        public static DateTime MinBirthDate
        {
            get { return minBirthDate; }
        }
        public DateTime BirthDate
        {
            get { return birthDate; }
            set { if (value > minBirthDate && value < DateTime.Now) birthDate = value; }
        }
        public int Year
        {
            get { return birthDate.Year; }
            set
            {
                birthDate = new DateTime(value, birthDate.Month, birthDate.Day);
            }
        }
        public int FullAge()
        {
            if (DateTime.Now.Month < birthDate.Month || DateTime.Now.Month == birthDate.Month && DateTime.Now.Day < birthDate.Day)

                return DateTime.Now.Year - birthDate.Year - 1;
            else return DateTime.Now.Year - birthDate.Year;
        }
        public string ToShortString()
        {
            return $"First Name: {firstName}, Last Name: {lastName}";

        }
        public override string ToString()
        {
            return $"First Name: {firstName}, Last Name: {lastName}, Birth Date: {birthDate}, Age: {FullAge()}";
        }

        public int CompareTo(object obj)
        {
            Person temp = (Person)obj;
            return string.Compare(lastName, temp.lastName);
        }
        public object Clone()
        {
            return new Person(firstName, lastName, birthDate);
        }
    }
}
