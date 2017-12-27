using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DMacro
{
    class MouseMove : MouseInput, IEvent
    {
        private Point Point;

        public MouseMove(Point point)
        {
            Point = point;
        }

        public int Run(Dictionary<string, object> variables)
        {
            MouseSimulator.MoveMouseTo(Point.X / Screen.PrimaryScreen.Bounds.Width * ushort.MaxValue, Point.Y / Screen.PrimaryScreen.Bounds.Height * ushort.MaxValue);

            return -1;
        }
    }
}
