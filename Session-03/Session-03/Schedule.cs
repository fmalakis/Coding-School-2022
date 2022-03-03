using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Schedule
    {
        public Guid ID { get; }

        public Guid CourseID { get; }
        public Guid ProfessorID { get; }
        public DateTime Calendar { get; }

        public Schedule(Guid _CourseID, Guid _professorID, DateTime _Calendar)
        {
            ID = Guid.NewGuid();
            CourseID = _CourseID;
            Calendar = _Calendar;
            ProfessorID = _professorID;
        }
    }
}
