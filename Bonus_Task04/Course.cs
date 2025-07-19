using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Task04
{
    internal class Course
    {
        public string Name { get; set; }
        public string Instructor { get; set; }

        public Course(string name, string instructor)
        {
            Name = name;
            Instructor = instructor;
        }
        public string DisplayDetails() // to show course details (Course name, Instructor)
        {
            return $"Course Name : {Name}  Instructor : {Instructor}";
        }

    }
}
