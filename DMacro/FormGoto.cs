using System;
using System.Windows.Forms;

namespace DMacro
{
    public partial class FormGoto : Form
    {
        public FormGoto(int eventsCount)
        {
            InitializeComponent();

            NumericUpDownLineToGo.Minimum = 0;
            NumericUpDownLineToGo.Maximum = eventsCount - 1;
        }

        public int GetLineToGo()
        {
            return (int)NumericUpDownLineToGo.Value;
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
