using System;
using System.Collections.Generic;
using System.Text;

namespace Mod2_SelfLab
{
    public abstract class Person
    {
        private string personName;
        private string personSex;
        private int age;

        public string Name { get => personName; set => personName = value; }
        public string Sex { get => personSex; set => personSex = value; }
        public int Age { get => age; set => age = value; }

        public Person(string name, string sex)
        {
            this.Name = name;
            this.Sex = sex;
        }
        public Person(string name, string sex, int age)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
        }
        public abstract int getID();
    }
}
