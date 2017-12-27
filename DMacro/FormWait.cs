using System;
using System.Windows.Forms;

namespace DMacro
{
    public partial class FormWait : Form
    {
        public FormWait()
        {
            InitializeComponent();
        }

        public int GetMilliseconds()
        {
            return (int)NumericUpDownMilliseconds.Value;
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
