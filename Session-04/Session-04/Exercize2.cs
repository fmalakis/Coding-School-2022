﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Exercize2
    {
        public Exercize2()
        {

        }

        public int ComputeResult(int n, int choice) 
        {

            int result;

            if (choice == 1)
            {
                result = 0;
            } else
            {
                result = 1;
            }

            for (int i = 1; i <= n; i++)
            {
                if (choice == 1)
                    result += i;
                else
                    result *= i;
            }

            return result;
        }
    }
}
