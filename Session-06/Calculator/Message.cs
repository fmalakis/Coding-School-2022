using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Message
    {
        public Guid ID { get; }
        public DateTime TimeStamp { get; }

        public Message()
        {
            ID = Guid.NewGuid();
            TimeStamp = DateTime.Now;
        }
    }
}
