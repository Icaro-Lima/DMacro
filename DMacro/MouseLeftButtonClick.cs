using System.Collections.Generic;

namespace DMacro
{
    class MouseLeftButtonClick : MouseInput, IEvent
    {
        public int Run(Dictionary<string, object> variables)
        {
            MouseSimulator.LeftButtonClick();

            return -1;
        }
    }
}
