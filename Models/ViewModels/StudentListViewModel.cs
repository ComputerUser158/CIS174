using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174.Models
{
    public class StudentListViewModel
    {
        public IEnumerable<Student> Students { get; set; }

        public RouteDictionary CurrentRoute { get; set; }
    }
}
