using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ActionResolver : Resolver
    {
        public MessageLogger Logger { get; }

        public ActionResolver(MessageLogger _Logger)
        {
            Logger = _Logger;
        }

        public override ActionResponse Execute(ActionRequest actionRequest)
        {

            string result = string.Empty;

            switch (actionRequest.Action)
            {
                case ActionType.Convert:
                    result = FloatToBinary(actionRequest.Input);
                    break;
                case ActionType.Uppercase:
                    result = LongestWordToUpercase(actionRequest.Input);
                    break;
                case ActionType.Reverse:
                    result = ReverseString(actionRequest.Input);
                    break;
                default:
                    result = "ERROR: Unsupported action";
                    break;
            }

            Logger.Write(new Message(result));

            return new ActionResponse(actionRequest.ID, result);
        }

        private string FloatToBinary(string input)
        {
            if (!Decimal.TryParse(input, out var result))
                return "ERROR: Input is not a decimal";

            return BitConverter.GetBytes(Convert.ToDouble(input))
            .Reverse()
            .Select(x => Convert.ToString(x, 2))
            .Select(x => x.PadLeft(8, '0'))
            .Aggregate((a, b) => a + b);  
        }

        private string LongestWordToUpercase(string input)
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

        private string ReverseString(string input)
        {
            if (input.Length > 0)
                return input[input.Length - 1] + ReverseString(input.Substring(0, input.Length - 1));
            else
                return input;
        }

    }
}
