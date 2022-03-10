using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLogic
{
    internal class University : Institute
    {

        public List<Student> Students { get; }
        public List<Professor> Professors { get; }
        public List<Course> Courses { get; }
        public List<Grade> Grades { get; }
        public List<Schedule> ScheduledCourses { get; }


        public University(string _Name, int _YearsInService) : base(_Name, _YearsInService)
        {
            Students = new List<Student>();
            Professors = new List<Professor>();
            Courses = new List<Course>();
            Grades = new List<Grade>();
            ScheduledCourses = new List<Schedule>();
        }
    }
}
