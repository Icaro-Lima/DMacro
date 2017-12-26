using System;
using System.Drawing;
using System.Windows.Forms;

namespace DMacro
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonAddEvent_Click(object sender, EventArgs e)
        {
            ContextMenuStripAddEvent.Show(ButtonAddEvent, new Point(0, 0));
        }

        private void AddEvent(IEvent ievent)
        {
            if (ListBoxEvents.SelectedIndex == -1)
            {
                ListBoxEvents.Items.Add(ievent);
            }
            else
            {
                ListBoxEvents.Items.Insert(ListBoxEvents.SelectedIndex, ievent);
            }
        }

        private void MouseLeftButtonClickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEvent(new MouseLeftButtonClick());
        }
    }
}
