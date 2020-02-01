using System;
using System.Collections.Generic;
using System.Text;

namespace Mod2_SelfLab
{
    public class Student : Person
    {
        private int numOfCourses;
        private Course[] coursesEnroll = new Course[20];

        public static int numberOfStudent = 0;
        public int NumOfCourses { get => numOfCourses; set => numOfCourses = value; }
        public Course[] CoursesEnroll { get => coursesEnroll; set => coursesEnroll = value; }
        public Student(string name, string sex) : base(name,sex)
        {
            this.NumOfCourses = 0;
            numberOfStudent++;
        }
        public Student(string name, string sex, int age) : base(name,sex, age)
        {
            this.NumOfCourses = 0;
            numberOfStudent++;
        }

        public override int getID()
        {
            return numberOfStudent;
        }
        public void TakeCourse(Course course)
        {
            course.NumberEnroll++; // multithread? tbd
            CoursesEnroll[NumOfCourses] = course;
            NumOfCourses++;
        }

        public bool TakeTest(Course course)
        {
            Console.WriteLine(this.Name + " has taken test of " + course.Name);
            return true;
        }
    }
}
