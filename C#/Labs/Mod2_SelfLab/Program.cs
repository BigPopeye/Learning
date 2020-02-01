using System;

namespace Mod2_SelfLab
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
            Students[1].TakeCourse(Course1);
            Students[2].TakeCourse(Course2);

           Teacher Teacher1 = new Teacher("Alex", "Male");
            Course1.AddTeacher(Teacher1);

            Teacher Teacher2 = new Teacher("Phonex", "Female");

            Degree Degree1 = new Degree("Bachelor");
            Degree1.AddCourse(Course1);
            Degree1.AddCourse(Course2);

            Program1.AddDegree(Degree1);

            Console.WriteLine($"Program Name : {Program1.Name} , more information :");
            foreach (var degree in Program1.Degrees)
            {
                if (degree == null)
                {
                    break;
                }
                Console.WriteLine($"Degree : {degree.Name} . Courses contains:");
                foreach (var course in degree.Courses)
                {
                    if (course == null)
                    {
                        break;
                    }
                    Console.WriteLine($"\n\tCourse  : {course.Name}");
                    Console.WriteLine($"\tProfessor : {course.CourseTeacher}");
                    Console.WriteLine($"\t\tStudents enrolled: {course.NumberEnroll}");
                }
            }
            Console.WriteLine($"Thank you!");
        }
    }
}
