using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy_OOP
{
    internal class Student : Person
    {
        public Student(string firstName, string lastName, string idNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.IdNumber = idNumber;
        }
    }
}
