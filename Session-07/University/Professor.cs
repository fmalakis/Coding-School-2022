using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLogic
{
    internal class Professor : Person
    {
        public string Rank { get; set; }
        public List<Course> courses { get; }
        public Professor(string _Name, int _Age, string _Rank) : base(_Name, _Age)
        {
            Rank = _Rank;
            courses = new List<Course>();
        }

        public void Teach(Course course, DateTime dateTime)
        {
            if (course == null) 
                return;

            courses.Add(course);
        }
    }
}
