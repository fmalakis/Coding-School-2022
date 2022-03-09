using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public abstract class Logger
    {
        public abstract void Write(OperationMessage message);
        public abstract void Remove(OperationMessage message);

    }
}
