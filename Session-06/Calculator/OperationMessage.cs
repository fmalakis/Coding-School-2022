using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class OperationMessage : Message
    {
        public ArithmeticalOperation ArithmeticalOperation { get; }
        public string Text;

        public OperationMessage(ArithmeticalOperation _ArithmeticalOperation ,string _Text)
        {
            Text = _Text;
            ArithmeticalOperation = _ArithmeticalOperation;
        }

    }
}
