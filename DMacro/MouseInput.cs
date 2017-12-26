namespace DMacro
{
    abstract class MouseInput : MouseOrKeyboardInput
    {
        protected static WindowsInput.MouseSimulator MouseSimulator = new WindowsInput.MouseSimulator(InputSimulator);
    }
}
