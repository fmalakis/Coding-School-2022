using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    // this would be more fitting if it was an interface, but since they haven't been
    // shown yet, this shall suffice
    internal abstract class Resolver
    {
        public abstract ActionResponse Execute(ActionRequest actionRequest);


        protected static string FloatToBinary(string input)
        {
            if (!input.All(char.IsDigit))
                return "ERROR: Input is not a decimal number";

            return Convert.ToString(Convert.ToInt64(input), 2);
        }

        protected static string LongestWordToUpercase(string input)
        {
            string[] splitWords = input.Split(' ');

            if (splitWords.Length < 2)
                return "ERROR: Input doesn't have more than 1 word.";

            int maxIndex = 0;
            int maxLength = splitWords[0].Length;

            for (int i = 1; i < splitWords.Length; i++)
            {
                if (splitWords[i].Length > maxLength)
                {
                    maxIndex = i;
                    maxLength = splitWords[i].Length;
                }

            }

            splitWords[maxIndex] = splitWords[maxIndex].ToUpper();

            return string.Join(" ", splitWords);

        }

        protected static string ReverseString(string input)
        {
            if (input.Length > 0)
                return input[input.Length - 1] + ReverseString(input.Substring(0, input.Length - 1));
            else
                return input;
        }

    }
}

