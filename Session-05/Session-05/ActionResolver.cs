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

            string result;

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
    }
}
