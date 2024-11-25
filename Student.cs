using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCAD16_Assignment3_2_2wpf
{
    public enum Month
    {
        January, February, March, April, May, June, July, August, September, October, November, December
    }
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public Month MonthOfAdmission { get; set; }
        public char Grade { get; set; }

        public void AddStudent(Student student)
        {
            DataSource.Students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            DataSource.Students.Remove(student);
        }
    }
}
