using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class ArithmeticOperationLogger : Logger
    {

        public List<OperationMessage> operationMessages;

        public ArithmeticOperationLogger()
        {
            operationMessages = new List<OperationMessage>();
        }
        public override void Remove(OperationMessage message)
        {
            foreach (var operationMessage in operationMessages)
            {
                if (operationMessage == message)
                    operationMessages.Remove(message);
            }
        }

        public override void Write(OperationMessage message)
        {
            operationMessages.Add(message);
        }

        public string FetchMessages()
        {
            string ret = string.Empty;

            foreach (var msg in operationMessages)
            {
                ret += $"ID: {msg.ID} | TimeStamp: {msg.TimeStamp} | Operation: {msg.ArithmeticalOperation} | {msg.Text}" + Environment.NewLine;
                ret += "--------------" + Environment.NewLine;
            }

            return ret;
        }
    }
}
