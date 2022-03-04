using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Exercize4
    {
        public Exercize4()
        {

        }

        public int[] MultiplyArrays(int[] arr1, int[] arr2)
        {

            int k = 0;

            int[] result = new int[arr1.Length * arr2.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
               for (int j = 0; j < arr2.Length; j++)
                {
                    result[k++] = arr1[i] * arr2[j];
                }
            }

            return result;

        }

    }
}
