using System;

namespace Mod3_SelfLab
{
    class Program
    {
        static void Main(string[] args)
        {
            UProgram Program1 = new UProgram("Information Technology");

            Student[] Students = new Student[20];
            Students[0] = new Student("Amy", "Female", 20);
            Students[1] = new Student("Bob", "Male", 21);
            Students[2] = new Student("Candy", "Female", 21);

            Course Course1 = new Course("Programming with C#");
            Course Course2 = new Course("SQL");

            Students[0].TakeCourse(Course1);
            Students[1].TakeCourse(Course2);
            Students[2].TakeCourse(Course1);

            Teacher Teacher1 = new Teacher("Alex", "Male");
            Course1.AddTeacher(Teacher1);

            Teacher Teacher2 = new Teacher("Phonex", "Female");

            Degree Degree1 = new Degree("Bachelor");
            Degree1.AddCourse(Course1);
            Degree1.AddCourse(Course2);

            Program1.AddDegree(Degree1);

            Console.WriteLine($"Program Name : {Program1.Name} , it contains {Program1.NumOfDegree()} degree(s). More information :\n");
            foreach (var degree in Program1.Degrees)
            {
                if (degree == null)
                {
                    break;
                }
                Console.WriteLine($"Degree : {degree.Name} . it contains {degree.NumOfCourse()} course(s). Courses information:");
                foreach (var course in degree.Courses)
                {
                    if (course == null)
                    {
                        break;
                    }
                    Console.WriteLine($"\nCourse  : {course.Name}");
                    Console.WriteLine($"Professor : {course.CourseTeacher}");
                    Console.WriteLine($"Students enrolled: {course.NumberEnroll}");
                    Console.WriteLine($"They are : (ID | Name | Gender | Age)");
                    course.Record.Print();
                    course.Record.Dispose();
                }
            }
            Console.WriteLine($"Thank you!");

            
        }
    }
}
