using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApplication
{
    internal class Student
    {
        public string Name { get; set; }
        public string Class { get; set; }
    }

    internal static class StudentExtensions
    {
        public static void DisplayStudentsInClass(this List<Student> students, string className)
        {
            var studentsInClass = students.Where(s => s.Class == className);
            Console.WriteLine("Students in Class : " + className);
            foreach (var student in studentsInClass)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
