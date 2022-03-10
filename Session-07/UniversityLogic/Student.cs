using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLogic
{
    internal class Student : Person
    {
        public int RegistrationNumber { get; }

        public List<Course> courses;

        public Student(string _Name, int _Age, int _RegistrationNumber) : base(_Name,_Age)
        {
            courses = new List<Course>();
            RegistrationNumber = _RegistrationNumber;
        }

        public void Attend(Course course, DateTime dateTime)
        {
            if (course == null)
                return;

            courses.Add(course);
        }
    }
}
