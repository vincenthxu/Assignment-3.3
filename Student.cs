using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3._3
{
    public class Student
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public string? Address { get; set; }
        public Month MonthOfAdmission { get; set; }
        public char Grade { get; set; }
        public static List<Student> MockData(int numberOfEntries = 10)
        {
            List<Student> Students = new();
            for (int i = 0; i < numberOfEntries; i++)
            {
                Students.Add(new Student() { Id = i, FirstName = $"Student {i}", LastName = $"{i}", Address = $"Address {i}", MonthOfAdmission = (Month)(i%12), Grade = 'I' });
            }
            return Students;
        }
    }
}
