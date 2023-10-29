using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPApplication;

namespace OOPApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            students.Add(new Student { Name = "Kunal", Class = "Class 12" });
            students.Add(new Student { Name = "Sumon", Class = "Class 10" });
            students.Add(new Student { Name = "Punit", Class = "Class 8" });


            List<Teacher> teachers = new List<Teacher>();

            teachers.Add(new Teacher { Name = "Vishal", Class = "Class 12" });
            teachers.Add(new Teacher { Name = "Sumit", Class = "Class 10" });
            teachers.Add(new Teacher { Name = "Karan", Class = "Class 8" });

            List<Subject> subjects = new List<Subject>();

            subjects.Add(new Subject { Name = "Math", SubjectCode = "MATH101", Teacher = teachers[0] });
            subjects.Add(new Subject { Name = "Science", SubjectCode = "SCI104", Teacher = teachers[1] });
            subjects.Add(new Subject { Name = "Geography", SubjectCode = "GEOG107", Teacher = teachers[2] });

            teachers[0].SubjectsTaught.Add(subjects[0]);
            teachers[2].SubjectsTaught.Add(subjects[0]);
            teachers[1].SubjectsTaught.Add(subjects[2]); 
            teachers[2].SubjectsTaught.Add(subjects[2]); 



            Console.WriteLine("Enter subjects taught by teachers:");
            foreach (var teacher in teachers)
            {
                Console.WriteLine($"For Teacher: {teacher.Name}");
        
            }


            students.DisplayStudentsInClass("Class 12");
            teachers.DisplaySubjectsTaughtByTeacher("Sumit");
           

            Console.ReadLine();
                
        }

        
       
        

    }
}
