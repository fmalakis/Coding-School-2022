using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class Message
    {
        public Guid ID { get; }
        public DateTime TimeStamp { get; }
        public string MessageBody { get; }
        public Message(string _MessageBody)
        {
            ID = Guid.NewGuid();
            TimeStamp = DateTime.Now;
            MessageBody = _MessageBody;
        }
    }
}
