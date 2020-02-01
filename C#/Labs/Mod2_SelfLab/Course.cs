using System;
using System.Collections.Generic;
using System.Text;

namespace Mod2_SelfLab
{
    public class Course
    {
        public string Name { get; set; }
        //one course only have one teacher
        public Teacher CourseTeacher { get; set; }

        public int NumberEnroll { get; set; }

        public Course(string name)
        {
            this.Name = name;
            this.NumberEnroll = 0;
        }
        public void AddTeacher(Teacher teacher)
        {
            this.CourseTeacher = teacher;
        }
    }
}
