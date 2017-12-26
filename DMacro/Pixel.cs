using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;

namespace DMacro
{
    class Pixel : IEvent
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetDesktopWindow();
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetWindowDC(IntPtr window);
        [DllImport("gdi32.dll", SetLastError = true)]
        public static extern uint GetPixel(IntPtr dc, int x, int y);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int ReleaseDC(IntPtr window, IntPtr dc);

        private Color ColorToCompare;
        private Point Point;
        private int LineToGoIfTrue;
        private int LineToGoIfFalse;

        public Pixel(Color colorToCompare, Point point, int lineToGoIfTrue, int lineToGoIfFalse)
        {
            ColorToCompare = colorToCompare;
            Point = point;
            LineToGoIfTrue = lineToGoIfTrue;
            LineToGoIfFalse = lineToGoIfFalse;
        }

        public int Run(Dictionary<string, object> variables)
        {
            IntPtr desk = GetDesktopWindow();
            IntPtr dc = GetWindowDC(desk);
            int a = (int)GetPixel(dc, Point.X, Point.Y);
            ReleaseDC(desk, dc);

            if (ColorToCompare == Color.FromArgb(255, (a >> 0) & 0xff, (a >> 8) & 0xff, (a >> 16) & 0xff))
            {
                return LineToGoIfTrue;
            }
            else
            {
                return LineToGoIfFalse;
            }
        }
    }
}
