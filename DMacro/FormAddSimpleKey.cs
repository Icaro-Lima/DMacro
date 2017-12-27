using System;
using System.Windows.Forms;
using WindowsInput.Native;

namespace DMacro
{
    public partial class FormAddSimpleKey : Form
    {
        public FormAddSimpleKey()
        {
            InitializeComponent();

            foreach (VirtualKeyCode keyCode in Enum.GetValues(typeof(VirtualKeyCode)))
            {
                ComboBoxKey.Items.Add(keyCode);
            }
            ComboBoxKey.SelectedIndex = 0;
        }

        public VirtualKeyCode GetKeyCode()
        {
            return (VirtualKeyCode)ComboBoxKey.SelectedItem;
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
