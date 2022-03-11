using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLogic
{
    public class Course
    {
        public Guid Id { get; }
        public string Code { get; }
        public string Subject { get; }

        public Course(string _Code, string _Subject)
        {
            Code = _Code;
            Subject = _Subject;
        }
    }
}
