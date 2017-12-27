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
            ContextMenuStripAddEvent.Show(ButtonAddEvent, new Point());
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

            RemakeEnumeratedListBox();
        }

        private void ButtonRemoveSelected_Click(object sender, EventArgs e)
        {
            if (ListBoxEvents.SelectedIndex != -1)
            {
                ListBoxEvents.Items.RemoveAt(ListBoxEvents.SelectedIndex);

                RemakeEnumeratedListBox();
            }
        }

        private void RemakeEnumeratedListBox()
        {
            ListBoxEnumerated.Items.Clear();
            for (int i = 0; i < ListBoxEvents.Items.Count; i++)
            {
                ListBoxEnumerated.Items.Add(i);
            }
        }

        private void MouseLeftButtonClickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEvent(new MouseLeftButtonClick());
        }

        private void KeyboardKeyPressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddSimpleKey formAddSimpleKey = new FormAddSimpleKey();
            formAddSimpleKey.ShowDialog(this);

            AddEvent(new KeyboardKeyPress(formAddSimpleKey.GetKeyCode()));
        }

        private void WaitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormWait formWait = new FormWait();
            formWait.ShowDialog(this);

            AddEvent(new Wait(formWait.GetMilliseconds()));
        }

        private void GotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoto formGoto = new FormGoto(ListBoxEvents.Items.Count);
            if (formGoto.ShowDialog(this) == DialogResult.OK)
            {
                AddEvent(new Goto(formGoto.GetLineToGo()));
            }
        }

        private void PixelColorCompareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormComparePixel formComparePixel = new FormComparePixel(ListBoxEvents.Items.Count);
            if (formComparePixel.ShowDialog(this) == DialogResult.OK)
            {
                AddEvent(new Pixel(formComparePixel.GetColorToCompare(), formComparePixel.GetPixelPosition(), formComparePixel.GetLineToGoIfEquals(), formComparePixel.GetLineToGoIfNotEquals()));
            }
        }
    }
}
