using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Exercize1
    {
        public Exercize1()
        {

        }

        public string ReverseString(string inputString)
        {
            string outputString = string.Empty;

            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                outputString += inputString[i];
            }

            return outputString;
        }
    }
}
