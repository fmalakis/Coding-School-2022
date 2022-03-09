using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public abstract class Resolver
    {
        public abstract string Execute(ArithmeticalOperation arithmeticalOperation, string a, string b);
        public abstract string Execute(ArithmeticalOperation arithmeticalOperation, string a);

    }
}
