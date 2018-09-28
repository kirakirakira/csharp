using System.Collections.Generic;
using System;

namespace Treehouse
{
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student() { Name = "Sally", GradeLevel = 3 },
                new Student() { Name = "Bob", GradeLevel = 3 },
                new Student() { Name = "Sally", GradeLevel = 2 },
            };

            SchoolRoll schoolRoll = new SchoolRoll();
            schoolRoll.AddStudents(students);

            schoolRoll.Students.RemoveAt(0);
            schoolRoll.Students.Sort();

            schoolRoll.Students.AddRange(students);

            // students.Sort();

            // Student newStudent = new Student() { Name = "Joe", GradeLevel = 2 };

            // int index = students.BinarySearch(newStudent);

            // if(index < 0)
            // {
            //     students.Insert(~index, newStudent);
            // }

            foreach(Student student in schoolRoll.Students)
            {
                Console.WriteLine($"{student.Name} is in grade {student.GradeLevel}");
            }
        }
    }
}