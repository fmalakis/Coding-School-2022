using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Student : Person
    {
        private ushort coursesIndex;

        public int RegistrationNumber { get; }

        public Course[] Courses { get; }

        public Student(string _name, ushort _age) : base(_name, _age)
        {
            Courses = new Course[30];
            coursesIndex = 0;
        }

        public void Attend(Course course, DateTime dateTime)
        {
            if (coursesIndex >= Courses.Length)
                return;

            Courses[coursesIndex++] = course;

            // more code shall be added when a University field is added 
        }

        public void WriteExam(Course course, DateTime dateTime)
        {
            // doesn't do nothing yet, maybe with future additions to University class
        }
    }
}
