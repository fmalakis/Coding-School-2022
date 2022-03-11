using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLogic
{
    public class Student : Person
    {
        public int RegistrationNumber { get; set; }

        public List<Course> courses { get; set; }

        public Student(string _Name, int _Age, int _RegistrationNumber) : base(_Name,_Age)
        {
            courses = new List<Course>();
            RegistrationNumber = _RegistrationNumber;
        }

        public Student Clone()
        {
            return (Student)MemberwiseClone();
        }

        public void Attend(Course course, DateTime dateTime)
        {
            if (course == null)
                return;

            courses.Add(course);
        }

        public bool Compare(Student student)
        {
            return this.Name == student.Name
                && this.ID == student.ID
                && this.RegistrationNumber == student.RegistrationNumber
                && this.Age == student.Age;
        }
    }
}
