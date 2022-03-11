using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace UniversityLogic
{
    public class StudentManager
    {
        public List<Student> Students { get; set; }

        public StudentManager()
        {
            Students = new List<Student>();
        }

        public void Add(Student student)
        {

            if (student == null)
                throw new ArgumentNullException();

            Students.Add(student);
        }

        public void Remove(Student student)
        {
            Students.Remove(student);
        }

        public bool Update(Student student)
        {
            Student std = Students.FirstOrDefault(x => x.RegistrationNumber == student.RegistrationNumber);
            if (std == null)
                return false;

            std = student;
            return true;
        }

        public StudentManager Clone()
        {

            StudentManager clone = (StudentManager)MemberwiseClone();
            clone.Students = this.Students; 

            return clone;
        }
    }
}
