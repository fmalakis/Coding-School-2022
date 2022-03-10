using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLogic
{
    internal class Schedule
    {
        public Guid ID { get; }
        public Guid CourseID { get; }
        public Guid ProfessorID { get; }
        public DateTime TimeOfClass { get; set; }
        public Schedule(Guid _CourseID, Guid _ProfessorID, DateTime _TimeOfClass)
        {
            ID = Guid.NewGuid();
            CourseID = _CourseID;
            ProfessorID = _ProfessorID;
            TimeOfClass = _TimeOfClass;
        }
    }
}
