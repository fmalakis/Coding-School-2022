using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Proffesor : Person
    {
        private ushort courseIndex;

        private string Rank { get; }

        private Course[] Courses { get; }

        public Proffesor(string _name, ushort _age, string _rank) : base(_name, _age)
        {
            Name = "Dr." + _name;
            Rank = _rank;
            Courses = new Course[30];
            courseIndex = 0;
        }

        public void Teach(Course _course, DateTime dateTime)
        {
            if (courseIndex >= Courses.Length)
                return;

            Courses[courseIndex++] = _course;

            // needs additional code added once a University field is added
        }

        public void SetGrade(string studentID, string courseId, Grade grade)
        {
            // This method will be updated as soon as a University field is added to the class,
            // so that it can communicate with the Grades array in the University class
        }

        public string GetName()
        {
            return Name;
        }

    }
}
