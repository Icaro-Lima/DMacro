using System;
using System.Collections.Generic;
using WindowsInput.Native;

namespace DMacro
{
    class KeyboardKeyPress : KeyboardInput, IEvent
    {
        private VirtualKeyCode VirtualKeyCode;

        public KeyboardKeyPress(VirtualKeyCode keyCode)
        {
            VirtualKeyCode = keyCode;
        }

        public int Run(Dictionary<string, object> variables)
        {
            KeyboardSimulator.KeyPress(VirtualKeyCode);

            return -1;
        }

        public override string ToString()
        {
            return "Apertar a tecla " + VirtualKeyCode + ".";
        }
    }
}
