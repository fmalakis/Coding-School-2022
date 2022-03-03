using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Course
    {
        private Guid ID { get; }

        private string Code { get; }

        private string Subject { get; }

        public Course(string _code, string _subject)
        {
            ID = Guid.NewGuid();
            Code = _code;
            Subject = _subject;
        }
    }
}
