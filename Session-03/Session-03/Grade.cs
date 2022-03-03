using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Grade
    {
        private Guid ID { get; }

        private Guid StudentId { get; }
        private Guid CourseId { get; }
        private ushort GradeScore { get; }

        public Grade(Guid _studentId, Guid _courseId, ushort _gradeScore)
        {
            ID = Guid.NewGuid();
            StudentId = _studentId;
            CourseId = _courseId;
            GradeScore = _gradeScore;
        }

    }
}
