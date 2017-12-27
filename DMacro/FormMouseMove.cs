using System.Drawing;
using System.Windows.Forms;

namespace DMacro
{
    public partial class FormMouseMove : Form
    {
        Gma.System.MouseKeyHook.IKeyboardEvents KeyboardEvents;

        public FormMouseMove()
        {
            InitializeComponent();

            KeyboardEvents = Gma.System.MouseKeyHook.Hook.GlobalEvents();
            KeyboardEvents.KeyPress += KeyboardEvents_KeyPress;

            numericUpDownX.Maximum = Screen.PrimaryScreen.Bounds.Width - 1;
            numericUpDownY.Maximum = Screen.PrimaryScreen.Bounds.Height - 1;
        }

        public Point GetPoint()
        {
            return new Point((int)numericUpDownX.Value, (int)numericUpDownY.Value);
        }

        private void KeyboardEvents_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                numericUpDownX.Value = Cursor.Position.X;
                numericUpDownY.Value = Cursor.Position.Y;
            }
        }
    }
}
