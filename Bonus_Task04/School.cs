using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Task04
{
    internal class School
    {
        List<Student> Students = [];
        List<Course> Courses = [];

        public void AddStudent(Student student) // to add a new student to the school
        {
            Students.Add(student);
        }

        public void AddCourse(Course course) // to add a new course to the school
        {
            Courses.Add(course);
        }

        // public void EnrollStudentInCourse(int studentID, string courseName) // to enroll a student in a course
        // {
        //     
        // }

        public void EnrollStudentInCourse(Student student, Course course) // to enroll a student in a course
        {
            Students.Add(new(student.Name, student.ID));
            Courses.Add(new(course.Name, course.Instructor));
        }

        public void DisplayAllStudents() // to display details of all students in the school
        {
            for (int i = 0; i < Students.Count; i++)
                Console.WriteLine(Students[i]);
        }

        public void DisplayAllCourses() // to display details of all courses in the school
        {
            for (int i = 0; i < Courses.Count; i++)
                Console.WriteLine(Courses[i]);
        }
    }
}
