using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCAD16_Assignment3_2_2wpf
{
    internal class DataSource
    {
        public static List<Student> Students;

        public static void CreateData()
        {
            Students = new List<Student>()
            {
                new Student() {StudentId = 1, FirstName = "Philip", LastName = "Seisman", Address = "228 Sycamore St.", MonthOfAdmission = Month.January, Grade = 'A' },
                new Student() {StudentId = 2, FirstName = "Chris", LastName = "Smith", Address = "1 Antelope Cir.", MonthOfAdmission = Month.January, Grade = 'A' },
                new Student() {StudentId = 3, FirstName = "Jasmine", LastName = "George", Address = "13 NW Arnold St.", MonthOfAdmission = Month.January, Grade = 'A' }
            };
        }
    }
}
    