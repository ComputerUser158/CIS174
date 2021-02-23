using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System;


namespace CIS174.Models
{
    public class SeedStudents
    {
        
        public object StudentList = new List<Student>()
        {
                new Student() { FirstName = "Michelle", LastName = "Alexander", grade = 23 },
                new Student() { FirstName = "Stephen E.", LastName = "Ambrose", grade = 32 },
                new Student() { FirstName = "Margaret", LastName = "Atwood", grade = 36 },
                new Student() { FirstName = "Jane", LastName = "Austen", grade = 34 },
                new Student() { FirstName = "James", LastName = "Baldwin", grade = 21 }

        };
        
    }

}
