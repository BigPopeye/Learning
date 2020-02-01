using System;
using System.Collections.Generic;
using System.Text;

namespace Mod3_SelfLab
{
    class UProgram
    {
        private string name;
        private Degree[] degrees = new Degree[5];
        private int numOfDegree;

        public UProgram(string name)
        {
            this.Name = name;
            numOfDegree = 0;
        }

        public UProgram(string name, string degreeName)
        {
            this.Name = name;
            Degrees[numOfDegree].Name = degreeName;
            numOfDegree++;
        }

        public string Name { get => name; set => name = value; }
        internal Degree[] Degrees { get => degrees; set => degrees = value; }

        public void AddDegree(Degree degree)
        {
            Degrees[numOfDegree] = degree;
            numOfDegree++;
        }
        public int NumOfDegree()
        {
            return numOfDegree;
        }
    }
}
