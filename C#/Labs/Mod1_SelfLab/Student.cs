using System;
using System.Collections.Generic;
using System.Text;

namespace Mod1_SelfLab
{
    class Student
    {
        private string name;
        private string sex;
        private int age;
        private int numOfCourses;
        private Course[] coursesEnroll = new Course[20];
        
        public static int numberOfStudent = 0;

        public string Name { get => name; set => name = value; }
        public string Sex { get => sex; set => sex = value; }
        public int Age { get => age; set => age = value; }
        public int NumOfCourses { get => numOfCourses; set => numOfCourses = value; }
        public Course[] CoursesEnroll { get => coursesEnroll; set => coursesEnroll = value; }

        public Student()
        {
            numberOfStudent++;
        }
        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.NumOfCourses = 0;
            numberOfStudent++;
        }
        public Student(string name, string sex, int age)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
            this.NumOfCourses = 0;
            numberOfStudent++;
        }

        public void TakeCourse(Course course)
        {
            course.NumberEnroll++; // multithread? tbd
            CoursesEnroll[NumOfCourses] = course;
            NumOfCourses++;
        }
    }

    
}
