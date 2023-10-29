using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApplication
{
    internal class Teacher
    {
        public string Name { get; set; }
        public string Class { get; set; }

        public List<Subject> SubjectsTaught { get; set; }


        public Teacher()
        {
            SubjectsTaught = new List<Subject>();
        }
       
    }

    internal static class TeacherExtensions
    { 
            public static void DisplaySubjectsTaughtByTeacher(this List<Teacher> teachers, string teacherName)
            {
                var teacher = teachers.FirstOrDefault(t => t.Name == teacherName);
                if (teacher != null)
                {
                    Console.WriteLine("Subjects taught by " + teacherName + ":");
                    foreach (var subject in teacher.SubjectsTaught)
                    {
                        Console.WriteLine(subject.Name + " (Subject Code: " + subject.SubjectCode + ")");
                    }
                }
                else
                {
                    Console.WriteLine("Teacher not found.");
                }
            }
    }

}

