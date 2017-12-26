using System;
using System.Collections.Generic;
using WindowsInput.Native;

namespace DMacro
{
    class KeyboardKeyPress : KeyboardInput, IEvent
    {
        private VirtualKeyCode VirtualKeyCode;

        public KeyboardKeyPress(string key)
        {
            VirtualKeyCode = (VirtualKeyCode)Enum.Parse(typeof(VirtualKeyCode), key);
        }

        public int Run(Dictionary<string, object> variables)
        {
            KeyboardSimulator.KeyPress(VirtualKeyCode);

            return -1;
        }

        public override string ToString()
        {
            return "Apertar a tecla " + VirtualKeyCode;
        }
    }
}
