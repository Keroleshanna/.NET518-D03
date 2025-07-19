using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Task04
{
    internal class Student
    {
        public string Name { get; set; } = "No Name";
        public int ID { get; set; } = -1;
        List<Course> Courses { get; set; } = [];

        public Student(string name, int id)
        {
            Name = name;
            ID = id;
        }

        public void EnrollCourse(Course courseName) // To enroll a student in a course
        {
            Courses.Add(courseName);
        }

        public void DisplayDetails() // To show student details (Name, ID, courses)
        {
            Console.WriteLine($"Studnet Name is {Name} Student ID is {ID} : ");
            Console.WriteLine("His Enroll in courses: ");
            for(int i = 0; i < Courses.Count; i++)
            {
                Console.WriteLine($"{Courses[i].Name}");
            }
        }

        public Student(Student student)
        {
            student.Name = this.Name;
            student.ID = this.ID;
            List<Course> courses = [];

        }
    }
}
