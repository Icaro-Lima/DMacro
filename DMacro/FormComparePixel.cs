using System.Drawing;
using System.Windows.Forms;
using System.Timers;

namespace DMacro
{
    public partial class FormComparePixel : Form
    {
        private System.Timers.Timer Timer;
        private Gma.System.MouseKeyHook.IKeyboardEvents KeyboardHook;
        private Graphics Graphics;
        private Image Image;
        private Pen Pen;
        private Point PixelPosition;
        private ColorDialog ColorDialog;

        public FormComparePixel(int eventsCount)
        {
            InitializeComponent();

            KeyboardHook = Gma.System.MouseKeyHook.Hook.GlobalEvents();
            KeyboardHook.KeyPress += KeyboardHook_KeyPress;

            Image = new Bitmap(69, 69);
            Graphics = Graphics.FromImage(Image);
            Pen = new Pen(Color.Red);

            Timer = new System.Timers.Timer
            {
                Interval = 500,
                Enabled = true
            };
            Timer.Elapsed += Timer_Elapsed;

            ColorDialog = new ColorDialog
            {
                SolidColorOnly = true
            };

            NumericUpDownLineToGoIfEquals.Minimum = NumericUpDownLineToGoIfNotEquals.Minimum = 0;
            NumericUpDownLineToGoIfEquals.Maximum = NumericUpDownLineToGoIfNotEquals.Maximum = eventsCount - 1;
        }

        private void KeyboardHook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                if (Timer.Enabled)
                {
                    PixelPosition = Cursor.Position;
                    Timer.Enabled = false;
                }
                else
                {
                    Timer.Enabled = true;
                }
            }
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Graphics.CopyFromScreen(new Point(Cursor.Position.X - 69 / 2, Cursor.Position.Y - 69 / 2), new Point(), new Size(69, 69));
            Graphics.DrawRectangle(Pen, new Rectangle(Image.Width / 2 - 1, Image.Height / 2 - 1, 2, 2));
            PictureBoxSelectPixel.Image = (Image)Image.Clone();
        }

        public Point GetPixelPosition()
        {
            return PixelPosition;
        }

        public Color GetColorToCompare()
        {
            return ColorDialog.Color;
        }

        public int GetLineToGoIfEquals()
        {
            return (int)NumericUpDownLineToGoIfEquals.Value;
        }

        public int GetLineToGoIfNotEquals()
        {
            return (int)NumericUpDownLineToGoIfNotEquals.Value;
        }

        private void PictureBoxSelectColor_Click(object sender, System.EventArgs e)
        {
            ColorDialog.ShowDialog(this);

            PictureBoxSelectColor.BackColor = ColorDialog.Color;
        }
    }
}
