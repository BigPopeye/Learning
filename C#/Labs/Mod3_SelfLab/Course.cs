using System;
using System.Collections.Generic;
using System.Text;


namespace Mod3_SelfLab
{
    public class Course
    {
        public string Name { get; set; }
        public Teacher CourseTeacher { get; set; }
        //one course only have one teacher
        public int NumberEnroll { get; set; }
        public CourseRecord Record { get; set; }
        // record of the students who have enrolled this course

        public Course(string name)
        {
            this.Name = name;
            this.NumberEnroll = 0;
            this.Record = new CourseRecord(name);
        }
        public void AddTeacher(Teacher teacher)
        {
            this.CourseTeacher = teacher;
        }
    }
   
}
