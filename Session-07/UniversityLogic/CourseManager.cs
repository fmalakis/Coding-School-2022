using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniversityLogic
{
    public class CourseManager
    {
        public List<Course> Courses { get; set; }

        public CourseManager()
        {
            Courses = new List<Course>();
        }

        public void Add(Course course)
        {
            Courses.Add(course);
        }

        public void Update(Course course)
        {
            Course cs = Courses.FirstOrDefault(x => x.Id == course.Id);
            if (cs != null)
                cs = course;
        }

        public void Remove(Course course)
        {
            if (course == null)
                return;

            Courses.Remove(course);
        }
    }
}
