using System;
using System.Collections.Generic;
using System.Text;

namespace Mod1_SelfLab
{
    class Teacher
    {
        private string name;
        private string sex;
        private int numOfCourses;

        public static int numberOfTeacher = 0;

        public Course[] CoursesToTeach = new Course[5];
        public string Name { get => name; set => name = value; }
        public string Sex { get => sex; set => sex = value; }
        public int NumOfCourses { get => numOfCourses; set => numOfCourses = value; }

        public Teacher(string name, string sex)
        {
            this.Name = name;
            this.Sex = sex;
            this.NumOfCourses = 0;
            numberOfTeacher++;
        }
        public void TeachCourse(Course course)
        {
            CoursesToTeach[NumOfCourses] = course;
            NumOfCourses++;
        }
    }


}
