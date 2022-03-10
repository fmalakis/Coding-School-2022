using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLogic
{
    internal class Grade
    {
        public Guid ID { get; }
        public Guid StudentID { get; }
        public Guid CourseID { get; }
        public int Value { get; }

        public Grade(Guid _StudentID, Guid _CourseID, int _Value)
        {
            ID = Guid.NewGuid();
            StudentID = _StudentID;
            CourseID = _CourseID;
            Value = _Value;
        }

    }
}
