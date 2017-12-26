using System.Collections.Generic;

namespace DMacro
{
    interface IEvent
    {
        void Run(Dictionary<string, object> variables);
    }
}
