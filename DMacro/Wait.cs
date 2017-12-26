using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMacro
{
    class Wait : IEvent
    {
        private int Milliseconds;

        public Wait(int milliseconds)
        {
            Milliseconds = milliseconds;
        }

        public void Run(Dictionary<string, object> variables)
        {
            System.Threading.Thread.Sleep(Milliseconds);
        }
    }
}
