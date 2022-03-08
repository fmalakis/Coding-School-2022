using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ActionRequest : ActionDTO
    {
        public string Input { get; }

        public ActionType Action { get; }

        public ActionRequest(string _Input, ActionType _Action)
        {
            Input = _Input;
            Action = _Action;
        }
    }
}
