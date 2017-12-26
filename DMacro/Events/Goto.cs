using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMacro
{
    class Goto : IEvent
    {
        private int LineToGo;

        public Goto(int lineToGo)
        {
            LineToGo = lineToGo;
        }

        public int Run(Dictionary<string, object> variables)
        {
            return LineToGo;
        }
    }
}
