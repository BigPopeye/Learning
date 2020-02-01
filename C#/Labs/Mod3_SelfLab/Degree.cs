using System;
using System.Collections.Generic;
using System.Text;

namespace Mod3_SelfLab
{
    class Degree
    {
        private string name;
        private Course[] courses = new Course[50];
        private int numOfCourse;

        public string Name { get => name; set => name = value; }
        public Course[] Courses { get => courses; set => courses = value; }

        public Degree(string name)
        {
            this.Name = name;
            this.numOfCourse = 0;
        }
        public Degree(string name, Course[] courses)
        {
            this.Name = name;
            this.Courses = courses;
            numOfCourse = courses.Length;
        }
        public void AddCourse(Course course)
        {
            Courses[numOfCourse] = course;
            numOfCourse++;
        }
        public int NumOfCourse()
        {
            return numOfCourse;
        }
    }
}
