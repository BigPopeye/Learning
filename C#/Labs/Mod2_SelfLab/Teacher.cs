using System;
using System.Collections.Generic;
using System.Text;

namespace Mod2_SelfLab
{
    public class Teacher : Person
    {
        private int numOfCourses;

        public static int numberOfTeacher = 0;

        public Course[] CoursesToTeach = new Course[5];
        public int NumOfCourses { get => numOfCourses; set => numOfCourses = value; }
        public Teacher(string name, string sex) : base(name, sex)
        {
            this.numOfCourses = 0;
            numberOfTeacher++;
        }
        public override int getID()
        {
            return numberOfTeacher;
        }
        public void TeachCourse(Course course)
        {
            CoursesToTeach[NumOfCourses] = course;
            NumOfCourses++;
        }

        public bool GradeTest(Course course)
        {
            Console.WriteLine(this.Name + " has already graded test of " + course.Name);
            return true;
        }

    }
}
