using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Grade
    {
        public Guid ID { get; }

        public Guid StudentId { get; }
        public Guid CourseId { get; }
        public ushort GradeScore { get; }

        public Grade(Guid _studentId, Guid _courseId, ushort _gradeScore)
        {
            ID = Guid.NewGuid();
            StudentId = _studentId;
            CourseId = _courseId;
            GradeScore = _gradeScore;
        }

    }
}
