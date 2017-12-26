namespace DMacro
{
    class KeyboardInput : MouseOrKeyboardInput
    {
        protected WindowsInput.KeyboardSimulator KeyboardSimulator = new WindowsInput.KeyboardSimulator(InputSimulator);
    }
}
