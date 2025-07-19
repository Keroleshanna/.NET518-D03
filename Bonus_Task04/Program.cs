namespace Bonus_Task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course aspDotNet = new Course("ASP.NET", "Mohamed Nabih");
            Course frontEnd = new Course("frontEnd", "Ali Khaled");
            Course aI = new Course("AI", "Ahmed Mohamed");



            Student student1 = new Student("keroles", 123);
            Student student2 = new Student("Ahmed", 456);
            Student student3 = new Student("Bob", 789);
            // student.EnrollCourse(aspDotNet);
            // student.EnrollCourse(frontEnd);
            // student.EnrollCourse(aI);
            // student.DisplayDetails();

            School school = new School();
            school.AddStudent(student1);
            school.AddStudent(student2);
            school.AddStudent(student3);

            school.AddCourse(aI);
            school.AddCourse(frontEnd);
            school.AddCourse(aspDotNet);

            school.EnrollStudentInCourse(student1, aspDotNet);

        }
    }
}
