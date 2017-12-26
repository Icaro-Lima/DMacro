using System.Collections.Generic;

namespace DMacro
{
    class MouseLeftButtonClick : MouseInput, IEvent
    {
        public void Run(Dictionary<string, object> variables)
        {
            MouseSimulator.LeftButtonClick();
        }
    }
}
