using System.Collections.Generic;
using System;

namespace Treehouse
{
    class Program
    {
        static void Main()
        {
            HashSet<Student> students = new HashSet<Student>
            {
                new Student() { Name = "Sally", GradeLevel = 3 },
                new Student() { Name = "Bob", GradeLevel = 3 },
                new Student() { Name = "Sally", GradeLevel = 2 },
            };

            // SchoolRoll schoolRoll = new SchoolRoll();
            // schoolRoll.AddStudents(students);

            // schoolRoll.AddStudents(students);
            // students.Sort();

            // Student newStudent = new Student() { Name = "Joe", GradeLevel = 2 };

            // int index = students.BinarySearch(newStudent);

            // if(index < 0)
            // {
            //     students.Insert(~index, newStudent);
            // }

            Student joe = new Student() { Name = "Joe", GradeLevel = 2 };
            students.Add(joe);

            Student duplicateJoe = new Student() { Name = "Joe", GradeLevel = 2 };
            students.Add(duplicateJoe);

            if(students.Contains(joe))
            {
                Console.WriteLine("Found him!");
            }

            foreach(Student student in students)
            {
                Console.WriteLine($"{student.Name} is in grade {student.GradeLevel}");
            }
        }
    }
}