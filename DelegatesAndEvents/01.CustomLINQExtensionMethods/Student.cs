using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CustomLINQExtensionMethods
{
    class Student
    {
        private string name;
        private int grade;

        public Student(string name,int grade)
        {
            this.Name = name;
            this.Grade = grade;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Grade
        {
            get { return this.grade; }
            set { this.grade = value; }
        }
    }
}
