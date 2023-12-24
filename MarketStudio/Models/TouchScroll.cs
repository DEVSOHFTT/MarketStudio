using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketStudio
{
    internal class TouchScroll
    {
        Point mouseDownPoint;
        Panel parentPanel;
        public TouchScroll(Panel parentPanel)
        {
            this.parentPanel = parentPanel;
            AssingEvent(parentPanel);
        }

        void AssingEvent(Control control)
        {
            control.MouseDown += MouseDown;
            control.MouseMove += MouseMove;
            foreach (Control child in control.Controls)
            {
                AssingEvent(child);
            }
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                return;
            }

            Point pointDiference = new Point(Cursor.Position.X + mouseDownPoint.X, Cursor.Position.Y - mouseDownPoint.Y);

            if ((mouseDownPoint.X == Cursor.Position.X) && (mouseDownPoint.Y == Cursor.Position.Y))
            {
                return;
            }

            Point currAutoS = parentPanel.AutoScrollPosition;
            parentPanel.AutoScrollPosition = new Point(Math.Abs(currAutoS.X) - pointDiference.X, Math.Abs(currAutoS.Y) - pointDiference.Y);
            mouseDownPoint = Cursor.Position;
        }

        private void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.mouseDownPoint = Cursor.Position;
            }
        }
    }
}
