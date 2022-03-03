using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class University : Institute
    {
        private ushort scheduleIndex;

        private Student[] Students;
        private Course[] Courses;
        private Grade[] Grades;
        private Schedule[] ScheduledCorse;

        public University(string _name, ushort _yearsInService) : base(_name, _yearsInService)
        {
            Students = new Student[30];
            Courses = new Course[30];
            Grades = new Grade[30];
            ScheduledCorse = new Schedule[60];

            scheduleIndex = 0;
        }

        public Student[] GetStudents()
        {
            return Students;
        }

        public Course[] GetCourses()
        {
            return Courses;
        }

        public Grade[] GetGrades()
        {
            return Grades;
        }

        public void SetSchedule(Guid courseID, Guid professorID, DateTime dateTime) 
        {
            if (scheduleIndex >= ScheduledCorse.Length)
                return;

            ScheduledCorse[scheduleIndex++] = new Schedule(courseID, professorID, dateTime);
        }

    }
}
