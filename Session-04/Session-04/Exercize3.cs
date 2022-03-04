using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Exercize3
    {
        public Exercize3()
        {
             
        }

        public string FindPrimes(int n)
        {
            string res = string.Empty;

            for (int i = 2; i <= n; i++)
            {

                int numberOfDivisors = 0;

                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        numberOfDivisors++;
                    }

                    if (numberOfDivisors > 1)
                    {
                        break;
                    }
                }

                if (numberOfDivisors == 1)
                {
                    res += $"{i} ";
                }

            }

            return res;
        }
    }
}
