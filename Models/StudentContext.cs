using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CIS174.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        { }
        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student() { StudentId = 1, FirstName = "Michelle", LastName = "Alexander", grade = 23 },
                new Student() { StudentId = 2, FirstName = "Stephen E.", LastName = "Ambrose", grade = 32 },
                new Student() { StudentId = 3, FirstName = "Margaret", LastName = "Atwood", grade = 36 },
                new Student() { StudentId = 4, FirstName = "Jane", LastName = "Austen", grade = 34 },
                new Student() { StudentId = 5, FirstName = "James", LastName = "Baldwin", grade = 21 }
            );
        }
    }
}
