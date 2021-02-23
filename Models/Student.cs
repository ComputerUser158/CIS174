using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CIS174.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int grade { get; set; }

        public ICollection<StudentListViewModel> StudentListViewModel { get; set; }
    }
}
