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
    }
}
