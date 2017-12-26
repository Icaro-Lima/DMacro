using System.Collections.Generic;

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

        public override string ToString()
        {
            return "Ir para a linha " + LineToGo + ".";
        }
    }
}
