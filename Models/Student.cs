using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CIS174.Models
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Grade { get; set; }

        public Student(string firstName, string lastName, string grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

    }
}
